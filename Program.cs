using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
       
        static List<Film> liste = new List<Film>();
        public static void  FilmEkle()
        { 
            Console.WriteLine("Film adını girin: ");
            string film = Console.ReadLine();
            Film film1 = new Film(film );
            liste.Add(film1);
            
        }
        public static void FilmListele()
        {
            for (int i = 0; i< liste.Count; i++)
            {
                if (liste[i].İzlendi == true)
                {

                    Console.WriteLine("[X] "+ (i + 1) + ". " + liste[i].Ad +" - "+ liste[i].Puan+"/10");
                }
                else
                {
                    Console.WriteLine("[ ] "+ (i + 1)+ ". " + liste[i].Ad +" - "+ liste[i].Puan+"/10");
                }
            }
        }
        public static void İzlenen()
        {
            Console.WriteLine("İzlediğiniz filmin numarasını giriniz: ");
            int iz;
            if (!int.TryParse(Console.ReadLine(), out iz))
            {
                Console.WriteLine("Sayı girmeniz lazım");
                return;
            }
            if (iz <= 0 || iz > liste.Count)
            {
                Console.WriteLine("Hatalı giriş");
                return;
            }
            
            liste[iz - 1].İzlendi = true;
        }
        public static void Sil()
        {
            Console.WriteLine("Silmek istediğiniz filmin numarasını girin: ");
            int sil;
            if (!int.TryParse(Console.ReadLine(), out sil))
            {
                Console.WriteLine("Sayı girmeniz lazım");
                return;
            }
            if (sil <= 0 || sil > liste.Count)
            {
                Console.WriteLine("Hatalı giriş");
                return;
            }
            liste.RemoveAt(sil - 1);             
        }
        public static void Puanla()
        {
            Console.WriteLine("Hangi filmi puanlamak istiyorsunuz");
            int puanla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(liste[puanla - 1].Ad);
            Console.WriteLine("1 ila 10 arasında puanlayın");

            int puan;
            if (!int.TryParse(Console.ReadLine(), out puan))
            {
                Console.WriteLine("Sayı girmeniz lazım");
                return;
            }
            if(puan <=0 || puan >10)
            {
                Console.WriteLine("1 ila 10 arasında puanlayın");
                return; 
            }
            liste[puanla - 1].Puan = puan;
         
        }
        static void Main(string[] args)
        {
          
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemin numarasını giriniz:");
                Console.WriteLine("1-Film ekle, 2-Filmleri listele, 3-Film izlendi, 4-Film sil, 5-Listeyi sıfırla, 6-Puan ver ");

                int fm;
                if (!int.TryParse(Console.ReadLine(), out fm))
                {
                    Console.WriteLine("Sayı girmeniz lazım");
                    return;
                }
                
                switch (fm)
                {
                    case 1:
                        FilmEkle();
                        break;

                    case 2:
                        FilmListele();
                        break;
                    case 3:
                        İzlenen();
                        break;
                    case 4:
                        Sil();
                        break;
                    case 5:
                        liste.Clear();
                        break;
                    case 6:
                        Puanla();
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş");
                        return;

                }

                
            }
        }
    }
}
