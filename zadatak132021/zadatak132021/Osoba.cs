using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak132021
{
    class Osoba
    {
        string ime, prezime;
        int godRod, kg;

        public void setIme (string ime)
        {
            this.ime = ime;
        }

        public string getIme()
        {
            return this.ime;
        }


        public void setPrezime (string prezime)
        {
            this.prezime = prezime;
        }

        public string getPrezime()
        {
            return this.prezime;
        }


        public void setGodRod (int godRodo)
        {
            this.godRod = godRod;

        }

        public int getGodRod()
        {
            return this.godRod;
        }


        public void setKg (int kg)
        {
            this.kg = kg;
        }

        public int getKg()
        {
            return this.kg;
        }


    }
}
