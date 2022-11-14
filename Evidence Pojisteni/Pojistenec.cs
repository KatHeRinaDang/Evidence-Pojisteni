using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_Pojisteni
{
    internal class Pojistenec
    {
        public string JmenoPojisteneho { get; private set; }
        public string PrijmeniPojisteneho { get; private set; }
        public int VekPojisteneho { get; private set; }
        public int TelefonniCisloPojisteneho { get; private set; }

        public Pojistenec(string jmeno, string prijmeni, int vek, int telCislo)
        {
            JmenoPojisteneho = jmeno;
            PrijmeniPojisteneho = prijmeni;
            VekPojisteneho = vek;
            TelefonniCisloPojisteneho = telCislo;
        }
        /// <summary>
        /// Vypíše detaily pojištěného
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JmenoPojisteneho + " " + PrijmeniPojisteneho + " " + VekPojisteneho + " " + TelefonniCisloPojisteneho;
        }

    }
}
