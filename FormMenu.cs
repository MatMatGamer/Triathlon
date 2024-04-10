using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Triathlon
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_crudClubs_Click(object sender, EventArgs e)
        {
            var crudClubs = new CRUDClubs();
            crudClubs.ShowDialog();
        }

        private void btn_crudSubstance_Click(object sender, EventArgs e)
        {
            var crudSubstances = new CRUDSubstances();
            crudSubstances.ShowDialog();
        }
    }
}
