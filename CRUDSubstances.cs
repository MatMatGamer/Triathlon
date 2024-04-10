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
    public partial class CRUDSubstances : Form
    {
        private mpeltier_TriathlonContext db = new mpeltier_TriathlonContext();
        public CRUDSubstances()
        {
            InitializeComponent();
        }

        private void CRUDSubstances_Load(object sender, EventArgs e)
        {
            loadCombos();
        }

        private void loadCombos()
        {
            List<Substance> Substances = db.Substances.OrderBy((s) => s.Nom).ToList();
            cbSubtances.DataSource = Substances;
            cbSubtances.DisplayMember = "Nom";
            cbSubtances.ValueMember = "Id";

            List<Classe> Classes = db.Classes.OrderBy((c) => c.Libelle).ToList();
            cbClasses.DataSource = Classes;
            cbClasses.DisplayMember = "Libelle";
            cbClasses.ValueMember = "Id";

            cbClasses.SelectedItem = ((Substance)cbSubtances.SelectedItem).IdClasseNavigation;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!checkDecimal()) return;
            try
            {
                Substance substance = new Substance()
                {
                    Nom = tbNom.Text,
                    Seuil = Convert.ToDecimal(tbSeuilMax.Text),
                    IdClasseNavigation = (Classe)cbClasses.SelectedItem
                };

                db.Substances.Add(substance);
                db.SaveChanges();
                MessageBox.Show("Insertion effectuée avec succès", "Insertion effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCombos();
                cbSubtances.SelectedItem = substance;
                cbClasses.SelectedItem = substance.IdClasseNavigation;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de l'insertion : " + err.InnerException, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!checkDecimal()) return;
            try
            {
                Substance substance = (Substance)cbSubtances.SelectedItem;

                substance.Nom = tbNom.Text;
                substance.Seuil = Convert.ToDecimal(tbSeuilMax.Text);
                substance.IdClasseNavigation = (Classe)cbClasses.SelectedItem;
                

                db.Substances.Update(substance);
                db.SaveChanges();
                MessageBox.Show("Modification effectuée avec succès", "Modification effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadCombos();
                cbSubtances.SelectedItem = substance;
                cbClasses.SelectedItem = substance.IdClasseNavigation;
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
                Substance substance = (Substance)cbSubtances.SelectedItem;

                var confirmResult = MessageBox.Show("Êtes vous sûr de vouloir supprimer cette substance ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    db.Substances.Remove(substance);
                    db.SaveChanges();
                    MessageBox.Show("Suppression effectuée avec succès", "Suppression effectuée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadCombos();
                }
                else return;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lors de la suppression : " + err.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSubtances_SelectedIndexChanged(object sender, EventArgs e)
        {
            Substance substance = (Substance)cbSubtances.SelectedItem;
            tbNom.Text = substance.Nom;
            tbSeuilMax.Text = Convert.ToString(substance.Seuil);
            cbClasses.SelectedItem = substance.IdClasseNavigation;
        }

        private void tbSeuilMax_TextChanged(object sender, EventArgs e)
        {
            checkDecimal();
        }

        private bool checkDecimal()
        {
            tbSeuilMax.Text.Replace(".", ",");
            if (tbSeuilMax.Text.Contains(","))
            {
                if (tbSeuilMax.Text.Split(",")[1].Length > 3)
                {
                    MessageBox.Show("Seulement 3 nombres sont autorisés après la virgule...", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            try
            {
                Decimal d = Convert.ToDecimal(tbSeuilMax.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Vous devez entrez un nombre décimal valide.", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
