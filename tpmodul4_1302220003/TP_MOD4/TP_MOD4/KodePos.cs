using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD4
{
    internal class KodePos
    {
        private string[,] nomorKodePos = {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };

        public string GetKodePos(string kelurahan)
        {
            for (int i = 0; i < nomorKodePos.GetLength(0); i++)
            {
                if (nomorKodePos[i, 0] == kelurahan)
                {
                    return nomorKodePos[i, 1];
                }
            }
            return "Kode Pos Tidak Ada";
        }
    }
}
