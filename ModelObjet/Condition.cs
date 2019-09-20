using System;

namespace ModelObjet
{
    public class Condition
    {
        const int nbJours = 30;
        // Permet de savoir si on a le droit d'être remboursé
        // On l'est à condition que le nombre de jours ne dépasse pas 30 !
        public static bool Valider(int unNbDeJours)
        {
            if (unNbDeJours <= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Permet de renvoyer le montant MAX remboursé en fonction de la catégorie
        public static int CalculerMontantMax(string uneCategorie)
        {
            if(uneCategorie == "Livres")
            {
                return 30;
            }
            if(uneCategorie == "Jouets")
            {
                return 50;

            }
            if (uneCategorie == "Informatique")
            {
                return 1000;
            }
            else
            {
                return 0;
            }
        }
        //Permet de retourner le total remboursé en fonction de tous les critères
        public static double CalculerMontantRembourse(int unNbDeJours, string uneCategorie, bool estMembre, string unEtat, int unPrix)
        {
            if (Valider(unNbDeJours) == true)
            {
                return Convert.ToDouble(CalculerMontantMax(uneCategorie) + CalculerReductionMembre(estMembre) + CalculerReduction(unEtat));
            }
            else
            {
                return 0;
            }

        }

        //Permet de renvoyer la réduction si on est membre ou pas
        public static double CalculerReductionMembre(bool estMembre)
        {
            if (estMembre)
            {
                return 0;
            }
            else
            {
                return 0.2;
            }
        }

        //Permet de renvoyer la réduction en fonction de l'état de l'achat
        public static double CalculerReduction(string unEtat)
        {
            if (unEtat == "Abimé" || unEtat == "Très abimé")
            {
                return 0.3;
            }
            else
            {
                return 0.1;
            }
        }
    }
}
