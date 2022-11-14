using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_Pojisteni
{
    internal class DatabazePojistencu
    {
        private List<Pojistenec> pojistenci = new List<Pojistenec>();

        /// <summary>
        /// Přidá nového pojištěnce do databáze.
        /// </summary>
        /// <param name="jmeno">Jméno pojištěnce.</param>
        /// <param name="prijmeni">Příjmení pojištěnce.</param>
        /// <param name="vek">Věk pojištěnce.</param>
        /// <param name="telCisl">Telefonní číslo pojištěnce.</param>
        public void PridatNovehoPojistence(string jmeno, string prijmeni, int vek, int telCisl)
        {
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, vek, telCisl));
        }

        /// <summary>
        /// Vyhledá a vrátí pojištěnce dle jména a příjmení.
        /// </summary>
        /// <param name="jmeno">Jméno, dle kterého má hledat.</param>
        /// <param name="prijmeni">Příjmení, dle kterého má hledat.</param>
        /// <returns></returns>
        public List<Pojistenec> VyhledatPojisteneho(string jmeno, string prijmeni)
        {
            List<Pojistenec> nalezeniPojistenci = new List<Pojistenec>();

            foreach (Pojistenec pojisteny in pojistenci)
            {
                if ((pojisteny.PrijmeniPojisteneho.ToLower() == prijmeni.ToLower() && (pojisteny.JmenoPojisteneho.ToLower() == jmeno.ToLower())))
                    nalezeniPojistenci.Add(pojisteny);
            }
            
            return nalezeniPojistenci;
        }
        /// <summary>
        /// Vrací seznam všech pojištěnců.
        /// </summary>
        /// <returns></returns>
        public List<Pojistenec> SeznamPojistencu()
        {
            return pojistenci;
        }


    }
}
