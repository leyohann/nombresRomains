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
            string retour;
            switch (nombrearabe)
            {
                case 0:
                    throw new NotImplementedException();
                case 1:
                    retour = "I";
                    break;
                case 2:
                    retour = "II";
                    break;
                case 3:
                    retour = "III";
                    break;
                case 4:
                    retour = "IV";
                    break;
                case 5:
                    retour = "V";
                    break;
                case 6:
                    retour = "VI";
                    break;
                case 7:
                    retour = "VII";
                    break;
                case 8:
                    retour = "VIII";
                    break;
                case 9:
                    retour = "IX";
                    break;
                case 10:
                    retour = "X";
                    break;
                default:
                    retour = "";
                    break;
            }

            return retour;
        }
    }
}
