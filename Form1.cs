using System.Data.SQLite; // For System.Data.SQLite

namespace winformsTutorial
{
    public partial class Form1 : Form
    {
        public void connect2db()
        {
            string dbPath = "Data Source=database.sqlLite;";
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                label1.Text = "Connection to SQLite database established.";
                connection.Close();
                label1.Text = "Connection closed.";
            }
        }
        public Form1()
        {
            InitializeComponent();
            connect2db();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }
    }
}
