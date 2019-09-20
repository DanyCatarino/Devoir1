using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelObjet;

namespace ProjetDeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void ValiderTest()
        {
            // Le nombre de jours d'achat est < à 30 jours
            // Le nombre de jours d'achat est > à 30 jours
            bool nb1 = Condition.Valider(237);
            bool nb2 = Condition.Valider(14);
            Assert.AreEqual(false, nb1);
            Assert.AreEqual(true, nb2);
        }

        [TestMethod()]
        public void CalculerMontantMaxTest()
        {
            // Pour la catégorie livre
            // Pour la catégorie jouet
            // Pour la catégorie informatique
            int cat1 = Condition.CalculerMontantMax("Livres");
            int cat2 = Condition.CalculerMontantMax("Jouets");
            int cat3 = Condition.CalculerMontantMax("Informatique");
            Assert.AreEqual(30, cat1);
            Assert.AreEqual(50, cat2);
            Assert.AreEqual(1000, cat3);
        }

        [TestMethod()]
        public void CalculerMontantRembourseTest()
        {
            // Un livre achété 24 euros depuis 15 jours avec un état "Très abimé" en étant non membre
            bool nbJour1 = Condition.Valider(15);
            int cat1 = Condition.CalculerMontantMax("Livres");
            double montant1 = Condition.CalculerMontantRembourse(15, "Livres", false, "Très abimé", 24);
            double membre1 = Condition.CalculerReductionMembre(false);
            double reduc1 = Condition.CalculerReduction("Très abimé");

            // Un livre achété 24 euros depuis 15 jours avec un état "Bon" en étant membre
            bool nbJour2 = Condition.Valider(15);
            int cat2 = Condition.CalculerMontantMax("Livres");
            double montant2 = Condition.CalculerMontantRembourse(15, "Livres", false, "Très abimé", 24);
            double membre2 = Condition.CalculerReductionMembre(true);
            double reduc2 = Condition.CalculerReduction("Bon");

        }

        [TestMethod()]
        public void CalculerReductionMembreTest()
        {
            // Il est membre
            double membre1 = Condition.CalculerReductionMembre(true);
            // Il n'est pas membre
            double membre2 = Condition.CalculerReductionMembre(false);


        }

        [TestMethod()]
        public void CalculerReductionTest()
        {
            // Pour un état "bon"
            double reduc1 = Condition.CalculerReduction("Bon");
            // Pour un état "abimé"
            double reduc2 = Condition.CalculerReduction("Abimé");



        }
    }
}
