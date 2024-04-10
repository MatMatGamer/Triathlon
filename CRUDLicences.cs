using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class CRUDLicences : Form
    {
        private mpeltier_TriathlonContext db = new mpeltier_TriathlonContext();

        public CRUDLicences()
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

        private void CRUDLicences_Load(object sender, EventArgs e)
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
                cbClub.SelectedItem = club;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'insertion : " + err.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Club club = (Club)cbClub.SelectedItem;
                club.ClubVille = tbVille.Text;
                club.ClubTel = tbTel.Text;
                club.ClubNom = tbNom.Text;
                club.ClubCp = tbCP.Text;
                club.ClubRue = tbRue.Text;

                db.Clubs.Update(club);
                db.SaveChanges();
                MessageBox.Show("Modification effectuée", "Modification effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadComboBox();
                cbClub.SelectedItem = club;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la modification : " + err.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Club club = (Club)cbClub.SelectedItem;

                if (club.NbLicencies > 0)
                {
                    MessageBox.Show("Il est impossible de supprimer un club qui posséde des licences", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirmResult = MessageBox.Show("Êtes vous sûr de vouloir supprimer ce club ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    db.Clubs.Remove(club);
                    db.SaveChanges();
                    MessageBox.Show("Suppression effectuée", "Suppression effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadComboBox();
                }
                else return;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la suppression : " + err.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
