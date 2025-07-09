using Npgsql;

namespace EOQ_Project_Work
{
    public partial class EditForm : Form
    {
        public EditForm(string _alimento, short _anno, int _annualDemand, double _setupPrice, double _maintenanceCost)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.alimento         = _alimento;
            this.anno             = _anno;
            this.annual_demand    = _annualDemand;
            this.setup_price      = _setupPrice;
            this.maintenance_cost = _maintenanceCost;
        }

        // Private fields
        private string alimento;
        private short  anno;
        private int    annual_demand;
        private double setup_price;
        private double maintenance_cost;

        // Events
        private void editButton_Click(object sender, EventArgs e)
        {
            edit_data(this.alimento, this.anno, this.annual_demand, this.setup_price, this.maintenance_cost);
            this.Close();
        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Auxiliary methods
        private void edit_data(string _alimento, short _anno, int _annualDemand, double _setupPrice, double _maintenanceCost)
        {
            var connectionString = MenuForm.CONNECTION_STRING1 + MenuForm.PASSWORD + MenuForm.CONNECTION_STRING2;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string find_food_id = @"SELECT id
                                                FROM alimenti 
                                                WHERE LOWER(nome) = LOWER(@nome)";

                        int foodId = -1;
                        using (var cmd = new NpgsqlCommand(find_food_id, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("nome", _alimento);
                            foodId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string edit_dati_economici = @"UPDATE dati_economici 
                                                       SET domanda_annua = @domanda_annua,
                                                           costo_setup = @costo_setup,
                                                           costo_mantenimento = @costo_mantenimento
                                                       WHERE id_alimento = @id_alimento AND anno = @anno;";

                        using (var cmd = new NpgsqlCommand(edit_dati_economici, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("id_alimento", foodId);
                            cmd.Parameters.AddWithValue("anno", _anno);
                            cmd.Parameters.AddWithValue("domanda_annua", _annualDemand);
                            cmd.Parameters.AddWithValue("costo_setup", _setupPrice);
                            cmd.Parameters.AddWithValue("costo_mantenimento", _maintenanceCost);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Dati modificati correttamente!", "Completato");
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("Errore durante la modifica dei dati nel database. Stiamo risolvendo!", "Errore");
                        return;
                    }

                }

            }

        }

    }

}
