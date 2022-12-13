/** Jeu du nombre caché
 * auteur: EMDS
 * date: 23/05/2020
 */
 
using System;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration variables
            int valeur = 0, essai, nbre = 1;
            bool correct=false ;

            while ( !correct )
            {
                // saisie du nombre à chercher
                try
                {
                    Console.Write("Entrez le nombre à chercher = ");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Enrreur ");

                }
            }
            // effacer ecran avant saisie deuxieme joueur
            Console.Clear();

            // saisie du 1er essai
            Console.WriteLine("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());

            while (essai != valeur)
            {

                // test de l'essai par rapport à la valeur à chercher
                if (essai > valeur)

                {
                    Console.WriteLine("--> trop grand !");
                }
                else
                {
                    Console.WriteLine("--> trop petit !");
                }

              // saisie essai suivant
                Console.WriteLine("Entrez un nouvel essai = ");
                essai = int.Parse(Console.ReadLine());

              // compteur d'essais
                nbre = nbre + 1;

                
            }
            
            Console.WriteLine("super ! Vous avez fait "+nbre+" essai");
             Console.ReadLine();

        }
    }
}
             
           

       
    
