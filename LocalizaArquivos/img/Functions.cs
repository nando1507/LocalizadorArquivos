using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalizaArquivos.img
{
    class Functions
    {

        public static String[] letras = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public static String GetColumnLetterByIndex(Int32 col)
        {
            String celula = "";

            if (col > 26)
            {
                Int32 idxPrimeiraLetra = Math.Abs(col / 26);
                Int32 idxSegundaLetra = col - (Math.Abs(col / 26) * 26);
                if (idxSegundaLetra == 0)
                {
                    celula = String.Concat(letras[idxPrimeiraLetra - 2], letras[25]);
                }
                else
                {
                    celula = String.Concat(letras[idxPrimeiraLetra - 1], letras[idxSegundaLetra - 1]);
                }

            }
            else
            {
                celula = letras[col - 1];
            }

            return celula;
        }


        public static String GetCelulaByColumnIndex(Int32 col, Int32 row)
        {
            String celula = GetColumnLetterByIndex(col);

            return String.Concat(celula, row.ToString());
        }


    }
}
