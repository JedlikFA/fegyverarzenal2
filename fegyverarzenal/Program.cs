using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fegyverarzenal
{
    class Program
    {
        enum fegyverek {apaökle, uzi, lángszóró, kézigránát, revolver, gépágyú,shotgum };
        static void Main(string[] args)
        {
            // fegyverek kezemben = fegyverek.kézigránát;
            List<fegyverek> fegyvertár = new List<fegyverek>();
            //egy fegyvert csak egy példányban lehet tárolni
            Felpakol(fegyvertár);  //összes fegyvert
            Listázó(fegyvertár);
            Console.WriteLine(FegyverSzám());
            Kivesz(fegyvertár,fegyverek.gépágyú);    //egy fegyvert kivesz a tárból
            Listázó(fegyvertár);

            Felvesz();  //egy fegyvert berak a tár végére
            Listázó();

            Felvesz2();  //egy fegyvert berak az i helyére
            Listázó();
            int db = FegyverSzám();
            Listázó();
            Console.ReadKey();

            //fegyvertár.Add(fegyverek.uzi);
            //fegyvertár.Add(fegyverek.lángszóró);
            //  foreach (fegyverek item in fegyvertár)
            //{
            //        Console.WriteLine(item);
            //  }
            //fegyvertár.Remove(fegyverek.uzi);
            //  fegyvertár.Insert(0,fegyverek.kézigránát);
            //foreach (fegyverek cucc in fegyvertár)
            //  {
            //    Console.WriteLine(cucc);
            //   }

            //  Console.ReadKey();

            //List<fegyverek> fegyvertár = new List<fegyverek>();
            //fegyvertár.Add(fegyverek.uzi);
            //fegyvertár.Add(fegyverek.lángszóró);
            //fegyvertár.Add(fegyverek.uzi);
            //foreach (fegyverek fegyver in fegyvertár)
            //{
            //    Console.WriteLine(fegyver);
            //}


           // HashSet<int> lottószámok = new HashSet<int>();
           // Random rnd = new Random();
           // while (lottószámok.Count<5)
           // {
           //     int lottószám = rnd.Next(1, 91);
           //     lottószámok.Add(lottószám);
           // }
           // List<int> rendezett = lottószámok.ToList();
           // rendezett.Sort();
           // foreach (int számok in rendezett)
           // {
           //     Console.WriteLine(számok);
           // }
        }

        static void Felvesz(List<fegyverek> fegyvertár)
        {
            if (fegyvertár.Contains(fegyverek.uzi))
            {
                Console.WriteLine("Tele");
            }
            else
            {
                fegyvertár.RemoveAt(2);
                fegyvertár.Insert(2, fegyverek.uzi);
            }
        }

        static void Listázó(List<fegyverek> fegyvertár)
        {

        }

        static void Listázó(List<fegyverek> fegyvertár)
        {
            
        }

        static void Felpakol(List<fegyverek> fegyvertár)
         {
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.lángszóró);
            fegyvertár.Add(fegyverek.apaökle);
            fegyvertár.Add(fegyverek.kézigránát);
            fegyvertár.Add(fegyverek.revolver);
            fegyvertár.Add(fegyverek.gépágyú);
            fegyvertár.Add(fegyverek.shotgum);
        }

        static void Kivesz(List<fegyverek> fegyvertár, fegyverek gépágyú)
        {
            fegyvertár.Remove(fegyver);
        }
    }
}
