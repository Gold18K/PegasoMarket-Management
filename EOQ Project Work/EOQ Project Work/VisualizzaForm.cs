using Npgsql;
using System.Windows.Forms.DataVisualization.Charting;

namespace EOQ_Project_Work {
    public partial class VisualizzaForm : Form
    {
        public VisualizzaForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            chartEOQ.TabStop = false;
            chartEOQ.MouseDown += (s, e) => this.ActiveControl = null;

            chartEOQ.Series.Clear();
            chartEOQ.ChartAreas.Clear();

            listEOQ.TabStop = false;
            listEOQ.Items.Clear();

            comboBoxYearSx.Enabled = false;
            comboBoxYearDx.Enabled = false;

            List<String> alimenti = retrieve_foods();

            for (int i = 0; i != alimenti.Count; ++i)
                foodsComboBox.Items.Add(alimenti[i]);

            foodsComboBox.SelectionChangeCommitted += foodsComboBox_SelectionChangeCommitted;
        }

        // Events
        private void visualizeButton_Click(object sender, EventArgs e)
        {
            string? alimento = foodsComboBox.SelectedItem?.ToString();

            if (alimento == null)
            {
                MessageBox.Show("Seleziona un alimento!", "Errore");
                return;
            }

            string? intervalSx = comboBoxYearSx.SelectedItem?.ToString();
            string? intervalDx = comboBoxYearDx.SelectedItem?.ToString();

            if (intervalSx == null || intervalDx == null)
            {
                MessageBox.Show("Seleziona un intervallo valido!", "Errore");
                return;
            }

            if (short.Parse(intervalSx) > short.Parse(intervalDx))
            {
                MessageBox.Show("Seleziona un intervallo valido!", "Errore");
                return;
            }

            List<EconomicData> datiEconomici = retrieve_economic_data(alimento, short.Parse(intervalSx), short.Parse(intervalDx));

            chartEOQ.Series.Clear();
            chartEOQ.ChartAreas.Clear();

            listEOQ.Items.Clear();

            ChartArea areaEOQ = new ChartArea("areaEOQ");

            Series serie = new Series("EOQ")
            {
                ChartType   = SeriesChartType.Line,
                Color       = Color.FromArgb(102, 102, 255),
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize  = 7,                  
                MarkerColor = Color.FromArgb(102, 102, 255)
            };

            for (int i = 0; i < datiEconomici.Count; i++)
            {
                double eoq = Math.Sqrt((2 * datiEconomici[i].annual_emand * datiEconomici[i].setup_cost) / datiEconomici[i].maintenance_cost);

                serie.Points.AddXY(datiEconomici[i].year, Math.Round(eoq, 2));
                listEOQ.Items.Add($"{datiEconomici[i].year}: {Math.Round(eoq, 2)}");
            }

            chartEOQ.ChartAreas.Add(areaEOQ);
            chartEOQ.Series.Add(serie);
        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void foodsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chartEOQ.Series.Clear();
            chartEOQ.ChartAreas.Clear();

            listEOQ.Items.Clear();

            comboBoxYearSx.Items.Clear();
            comboBoxYearDx.Items.Clear();

            comboBoxYearSx.Enabled = true;
            comboBoxYearDx.Enabled = true;

            string? food = foodsComboBox.SelectedItem?.ToString();

            if (food == null)
            {
                MessageBox.Show("Errore, stiamo risolvendo!", "Errore");
                return;
            }

            List<String> anni = retrieve_years(food);

            for (int i = 0; i != anni.Count; ++i)
            {
                comboBoxYearSx.Items.Add(anni[i]);
                comboBoxYearDx.Items.Add(anni[i]);
            }

        }

        // Auxiliary methods
        private List<String>       retrieve_foods()
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
        private List<String>       retrieve_years(string _food)
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
        private List<EconomicData> retrieve_economic_data(string _food, short _leftYear, short _rightYear)
        {
            List<EconomicData> datiEconomici = [];

            var connectionString = MenuForm.CONNECTION_STRING1 + MenuForm.PASSWORD + MenuForm.CONNECTION_STRING2;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT de.anno, de.domanda_annua, de.costo_setup, de.costo_mantenimento " +
                                                   "FROM dati_economici de " +
                                                   "INNER JOIN alimenti a ON a.id = de.id_alimento " +
                                                   "WHERE a.nome = @nome AND (de.anno BETWEEN @leftYear AND @rightYear) " +
                                                   "ORDER BY de.anno ASC;", conn))
                {
                    cmd.Parameters.AddWithValue("nome", _food);
                    cmd.Parameters.AddWithValue("leftYear", _leftYear);
                    cmd.Parameters.AddWithValue("rightYear", _rightYear);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datiEconomici.Add(new EconomicData
                            {
                                year = reader.GetInt16(0),
                                annual_emand = reader.GetInt32(1),
                                setup_cost = reader.GetDouble(2),
                                maintenance_cost = reader.GetDouble(3)
                            });
                        }

                    }

                }
            }

            return datiEconomici;
        }

        // Auxiliary structs
        private struct EconomicData {
            public short  year;
            public int    annual_emand;
            public double setup_cost;
            public double maintenance_cost;
        };

    }

}
