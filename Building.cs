using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructeurs
{
    public class Building
    {
        //propriétés
        public int NombreEtage;
        public double TailleBatiment;
        public const int TAILLE_IDEALE = 3;
        public const int TAILLE_RDC = 3;

        //Constructeurs
        public Building()
        {
        }
        public Building (int nombreEtage, double tailleBatiment) 
        {
            NombreEtage = nombreEtage;
            TailleBatiment = tailleBatiment;
        }

        public Building(int nombreEtage)
        {
            NombreEtage = nombreEtage;

            TailleBatiment = nombreEtage*TAILLE_IDEALE + TAILLE_RDC;
        }

        //methode GetFloorMaxSize
        public double GetFloorMaxSize(double hauteur, int NbrEtages)
        {
            if (NbrEtages < 0)
            {
                Console.WriteLine("Nombre d'étage doit être supérieur ou égal à 0 : ");
            }

            if (NbrEtages == 0) { return TAILLE_RDC; }
            
            return hauteur/NbrEtages + TAILLE_RDC; 
        }

        //methode GetFloorCount
        public int GetFloorCount()  
        {
            return NombreEtage;
        }
        //methode GetSize
        public double GetSize()
        {
            return TailleBatiment;
        }
        public void display()
        {
            Console.WriteLine($"Les nombres d'étages du batiment sont : {GetFloorCount()}");
            Console.WriteLine($"Les nombres Max des étages sont : {GetFloorMaxSize(50.0, 5)} ");
            Console.WriteLine($"La taille du batiment est : {GetSize()}");
        }

    }

}
