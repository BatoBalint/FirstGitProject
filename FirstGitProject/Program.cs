using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstGitProject
{
    class Program
    {
        static List<Auto> AutoLista = new List<Auto>();
        static void Main()
        {
            Beolvasas();
            Console.ReadKey();
        }

        static void Beolvasas()
        {
            StreamReader r = new StreamReader("auto.csv");
            r.ReadLine();
            string sor;
            do
            {
                sor = r.ReadLine();
                string[] ertek = sor.Split(';');
                Auto a = new Auto(ertek[0], ertek[1], Convert.ToInt32(ertek[2]), Convert.ToInt32(ertek[3]), ertek[4], Convert.ToInt32(ertek[5]));
                AutoLista.Add(a);
            } while (!r.EndOfStream);
            r.Close();
        }
    }

    class Auto
    {
        private string _marka;
        private string _modell;
        private string _uzema;
        private int _ev;
        private int _km;
        private int _ar;

        public Auto(string marka, string modell, int ev, int km, string uzema, int ar)
        {
            Marka = marka;
            Modell = modell;
            Uzema = uzema;
            Ev = ev;
            Km = km;
            Ar = ar;
        }

        public string Marka { get => _marka; set => _marka = value; }
        public string Modell { get => _modell; set => _modell = value; }
        public string Uzema { get => _uzema; set => _uzema = value; }
        public int Ev { get => _ev; set => _ev = value; }
        public int Km { get => _km; set => _km = value; }
        public int Ar { get => _ar; set => _ar = value; }
    }
}