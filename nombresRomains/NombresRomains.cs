using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombresRomains
{
    public class ConvertisseurNombreRomain
    {
        public static string Convertir(int nombrearabe)
        {
            string retour = "";
                if (nombrearabe == 1)
                {
                    retour = "I";
                }
                else if (nombrearabe == 2)
                {
                    retour = "II";
                }
                else if (nombrearabe == 3)
                {
                    retour = "III";
                }

                return retour;
        }
    }
}
