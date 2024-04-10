using Microsoft.EntityFrameworkCore;
using Triathlon.Models;

namespace Triathlon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenu());


            // Programme permettant de print les informations de la substance n°1
            mpeltier_TriathlonContext db = new mpeltier_TriathlonContext();

            Substance sub1 = db.Substances.Include("IdClasseNavigation").Where(s => s.Id == 1).Single();
            System.Diagnostics.Debug.WriteLine(sub1.Nom + " à un seuil de " + sub1.Seuil.ToString() + " et appartient à la classe " + sub1.IdClasseNavigation.Libelle);

            // Programme permettant d'avoir une collection avec toutes les substances
            List<Substance> substances = db.Substances.Include("IdClasseNavigation").ToList();
            System.Diagnostics.Debug.WriteLine("Voici toutes les substances :");
            foreach (var sub in substances)
            {
                System.Diagnostics.Debug.WriteLine(" -  " + sub.Nom + " à un seuil de " + sub.Seuil.ToString() + " et appartient à la classe " + sub.IdClasseNavigation.Libelle);
            }

        }
    }
}