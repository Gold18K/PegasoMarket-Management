using Npgsql;

namespace EOQ_Project_Work
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            comboBoxYear.Enabled = false;

            List<String> alimenti = retrieve_foods();

            for (int i = 0; i != alimenti.Count; ++i)
                foodsComboBox.Items.Add(alimenti[i]);

            foodsComboBox.SelectionChangeCommitted += foodsComboBox_SelectionChangeCommitted;
        }

        // Events
        private void foodsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxYear.Items.Clear();
            comboBoxYear.Enabled = true;

            string? food = foodsComboBox.SelectedItem?.ToString();

            if (food == null)
            {
                MessageBox.Show("Errore, stiamo risolvendo!", "Errore");
                return;
            }

            List<String> anni = retrieve_years(food);

            for (int i = 0; i != anni.Count; ++i)
                comboBoxYear.Items.Add(anni[i]);

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string? food = foodsComboBox.SelectedItem?.ToString();

            if (food == null)
            {
                MessageBox.Show("Seleziona un alimento!", "Errore");
                return;
            }

            string? intervalSx = comboBoxYear.SelectedItem?.ToString();

            if (intervalSx == null)
            {
                MessageBox.Show("Seleziona un anno!", "Errore");
                return;
            }

            delete_data(food, short.Parse(intervalSx));

            comboBoxYear.Items.Clear();
            comboBoxYear.Enabled = true;

            List<String> anni = retrieve_years(food);

            for (int i = 0; i != anni.Count; ++i)
                comboBoxYear.Items.Add(anni[i]);

        }
        private void gobackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Auxiliary methods
        private List<String> retrieve_foods()
        {
            List<String> alimenti = [];

            var connectionString = MenuForm.CONNECTION_STRING1 + MenuForm.PASSWORD + MenuForm.CONNECTION_STRING2;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT nome FROM alimenti ORDER BY nome ASC;", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        alimenti.Add(reader.GetString(0));
                    }
                }
            }

            return alimenti;
        }
        private List<String> retrieve_years(string _food)
        {
            List<String> anni = [];

            var connectionString = MenuForm.CONNECTION_STRING1 + MenuForm.PASSWORD + MenuForm.CONNECTION_STRING2;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand(@"SELECT de.anno 
                                                     FROM dati_economici de 
                                                     INNER JOIN alimenti a ON de.id_alimento = a.id 
                                                     WHERE a.nome = @nome ORDER BY de.anno ASC;", conn))
                {
                    cmd.Parameters.AddWithValue("nome", _food);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            anni.Add(reader.GetInt16(0).ToString());
                        }
                    }

                }

            }

            return anni;
        }
        private void delete_data(string _food,
                                 short _year)
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
                            cmd.Parameters.AddWithValue("nome", _food);
                            foodId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        string edit_dati_economici = @"DELETE FROM dati_economici
                                                       WHERE id_alimento = @id_alimento AND anno = @anno";

                        using (var cmd = new NpgsqlCommand(edit_dati_economici, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("id_alimento", foodId);
                            cmd.Parameters.AddWithValue("anno", _year);

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Dati eliminati correttamente!", "Completato");
                    }
                    catch
                    {
                        transaction.Rollback();
                        MessageBox.Show("Errore durante l'eliminazione dei dati dal database. Stiamo risolvendo!", "Errore");
                        return;
                    }

                }

            }
        }
    }

}
