using Triathlon.Models;

namespace Triathlon
{
    public partial class Form1 : Form
    {
        private mpeltier_TriathlonDuThonContext db = new mpeltier_TriathlonDuThonContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Clubs.ToList();
        }
    }
}