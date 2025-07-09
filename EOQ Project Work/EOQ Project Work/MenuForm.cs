
namespace EOQ_Project_Work
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Static fields
        public static string CONNECTION_STRING1 = "Host=ep-bitter-morning-a8xlakz2-pooler.eastus2.azure.neon.tech;Username=neondb_owner;Password=";
        public static string PASSWORD           = "npg_q0DPo7pFbsda";
        public static string CONNECTION_STRING2 = ";Database=neondb;Ssl Mode=Require;Trust Server Certificate=true;Channel Binding=Require";

        // Events
        private void visualizeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualizzaForm visualizzaForm = new VisualizzaForm();
            visualizzaForm.ShowDialog();
            this.Show();
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEditForm addEditForm = new AddEditForm();
            addEditForm.ShowDialog();
            this.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
            this.Show();
        }

    }

}
