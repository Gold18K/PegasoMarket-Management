using Npgsql;

namespace EOQ_Project_Work
{
    public partial class AddEditForm : Form
    {
        public AddEditForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Events
        private void gobackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addButton_Click(object sender, EventArgs e)
        {

            if (textBoxFood.Text == "")
            {
                MessageBox.Show("Inserisci un alimento!", "Errore");
                return;
            }

            short year = short.TryParse(textBoxYear.Text, out year) ? year : (short)-1;

            if (year == -1 || year < 0)
            {
                MessageBox.Show("Inserisci un anno valido!", "Errore");
                return;
            }

            int annual_emand = int.TryParse(textBoxAnnualDemand.Text, out annual_emand) ? annual_emand : -1;

            if (annual_emand == -1 || annual_emand < 0)
            {
                MessageBox.Show("Inserisci una domanda annua valida!", "Errore");
                return;
            }

            double setup_cost = double.TryParse(textBoxSetupCost.Text, out setup_cost) ? setup_cost : -1;

            if (setup_cost == -1 || setup_cost < 0)
            {
                MessageBox.Show("Inserisci un costo di setup valido!", "Errore");
                return;
            }

            double maintenance_cost = double.TryParse(textBoxMaintenanceCost.Text, out maintenance_cost) ? maintenance_cost : -1;

            if (maintenance_cost == -1 || maintenance_cost < 0)
            {
                MessageBox.Show("Inserisci un costo di mantenimento valido!", "Errore");
                return;
            }

            string foodName                    = char.ToUpper(textBoxFood.Text[0]) + textBoxFood.Text.Substring(1).ToLower();
            double setup_cost_correction       = double.Parse(textBoxSetupCost.Text.Replace('.', ','));
            double maintenance_cost_correction = double.Parse(textBoxMaintenanceCost.Text.Replace('.', ','));

            if (check_already_present(textBoxFood.Text, year))
            {
                EditForm editForm = new EditForm(foodName, year, annual_emand, setup_cost_correction, maintenance_cost_correction);
                editForm.ShowDialog();
                this.Show();
            }

            else
            {
                insert_data(foodName, year, annual_emand, setup_cost_correction, maintenance_cost_correction);
            }
                
        }

        // Auxiliary methods
        private bool check_already_present(string _alimento, short _anno)
        {
            var connectionString = MenuForm.CONNECTION_STRING1 + MenuForm.PASSWORD + MenuForm.CONNECTION_STRING2;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT EXISTS (" +
                                                   "SELECT 1 " +
                                                   "FROM dati_economici de " +
                                                   "INNER JOIN alimenti a ON a.id = de.id_alimento " +
                                                   "WHERE LOWER(a.nome) = LOWER(@alimento) AND de.anno = @anno);", conn))
                {
                    cmd.Parameters.AddWithValue("alimento", _alimento);
                    cmd.Parameters.AddWithValue("anno", _anno);

                    return Convert.ToBoolean(cmd.ExecuteScalar());
                }
            }

        }
        private void insert_data(string _alimento, short _anno, int _annualDemand, double _setupPrice, double _maintenanceCost)
        {
            var connectionString = MenuForm.CONNECTION_STRING1 + MenuForm.PASSWORD + MenuForm.CONNECTION_STRING2;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string insert_food = @"INSERT INTO alimenti (nome)
                                               VALUES (@nome)
                                               ON CONFLICT (nome) DO UPDATE
                                               SET nome = EXCLUDED.nome
                                               RETURNING id;";

                        int foodId = -1;
                        using (var cmd = new NpgsqlCommand(insert_food, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("nome", _alimento);
                            foodId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string insert_dati_economici = @"INSERT INTO dati_economici 
                                                         (id_alimento, anno, domanda_annua, costo_setup, costo_mantenimento)
                                                         VALUES (@id_alimento, @anno, @domanda_annua, @costo_setup, @costo_mantenimento)
                                                         ON CONFLICT (id_alimento, anno) DO NOTHING;";

                        using (var cmd = new NpgsqlCommand(insert_dati_economici, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("id_alimento", foodId);
                            cmd.Parameters.AddWithValue("anno", _anno);
                            cmd.Parameters.AddWithValue("domanda_annua", _annualDemand);
                            cmd.Parameters.AddWithValue("costo_setup", _setupPrice);
                            cmd.Parameters.AddWithValue("costo_mantenimento", _maintenanceCost);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Dati inseriti correttamente nel database!", "Completato");
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("Errore durante l'inserimento dei dati nel database. Stiamo risolvendo!", "Errore");
                        return;
                    }

                }

            }

        }

    }

}
