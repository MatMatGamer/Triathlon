using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triathlon.Models;

namespace Triathlon
{
    public partial class CRUDClubs : Form
    {
        private mpeltier_TriathlonDuThonContext db = new mpeltier_TriathlonDuThonContext();

        public CRUDClubs()
        {
            InitializeComponent();
        }

        private void loadComboBox()
        {
            List<Club> Clubs = db.Clubs.OrderBy((c) => c.ClubNom).ToList();
            cbClub.DataSource = Clubs;
            cbClub.DisplayMember = "ClubNom";
            cbClub.ValueMember = "ClubId";
        }

        private void CRUDClubs_Load(object sender, EventArgs e)
        {
            loadComboBox();
        }

        private void cbClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            Club club = (Club)cbClub.SelectedItem;
            tbCP.Text = club.ClubCp;
            tbNom.Text = club.ClubNom;
            tbRue.Text = club.ClubRue;
            tbTel.Text = club.ClubTel;
            tbVille.Text = club.ClubVille;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Club club = new Club()
                {
                    ClubVille = tbVille.Text,
                    ClubTel = tbTel.Text,
                    ClubNom = tbNom.Text,
                    ClubCp = tbCP.Text,
                    ClubRue = tbRue.Text
                };

                db.Clubs.Add(club);
                db.SaveChanges();
                MessageBox.Show("Insertion effectuée", "Insertion effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadComboBox();
                cbClub.SelectedIndex = club.ClubId;
            } catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la insertion : " + err.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
