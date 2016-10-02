using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatısSistemi
{
    class Program
    { 
        static int[] koltukno=new int[34];
        static yolcu[] yolcu=new yolcu[34];
      
    
        static void Main(string[] args)
        {
            for (int i = 0; i < yolcu.Length; i++)
            {
                yolcu[i] = new yolcu();
                yolcu[i].Durum = "BOŞ";
            }
            do
            {
                //System.Threading.Thread.Sleep(500);
                //Console.Clear();
               
                menu: Console.WriteLine("Cıkmak icin              =>1\nDevam için               =>2\nBos koltuk listesi için  =>3\nBütün yolcu listesi için =>4 ");
                int secim = Convert.ToInt32(Console.ReadLine());
                
                switch (secim)
                {
                    case 1:
                  Environment.Exit(1);
                        break;
                    case 2:
                        Devam();
                        break;
                    case 3:
                        BosKoltukListele();
                        break;
                    case 4:
                        ButunYolcuListesi();
                        break;
                    default: goto menu;
                }
               
            } while (true);

        }

        public static void ButunYolcuListesi()
        {
            for (int i = 0; i < yolcu.Length; i++)
            {
                if (yolcu[i].Durum.Equals("DOLU"))
                {
                    Console.WriteLine(" " + yolcu[i].ToString());
                }
            }
        }

        public static void Devam()
        {
          buraya:  Console.WriteLine("lütfen koltuk seciniz:");
            int secilen = Convert.ToInt32(Console.ReadLine());

            if (yolcu[secilen - 1].Durum.Equals("BOŞ"))
            {
                Console.WriteLine("adınızı girin:");
                yolcu[secilen - 1].Ad = Console.ReadLine();
                Console.WriteLine("soyadınızı girin:");
                yolcu[secilen - 1].Soyad = Console.ReadLine();
                yolcu[secilen - 1].Durum = "DOLU";
                yolcu[secilen - 1].KoltukNo = secilen;
               
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bu koltugu " + yolcu[secilen - 1].Ad + " " + yolcu[secilen - 1].Soyad+" satın almıstır.\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                goto buraya; 
            }
        }
        public static void BosKoltukListele()
        {  
            Console.WriteLine("Koltuk No:    Yolcu                  Koltuk no:    Yolcu");
            Console.WriteLine("----------    -----                  ----------    -----");
            for (int i = 0; i < koltukno.Length; i += 2)
            {
                if (yolcu[i].Durum.Equals("DOLU"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0,5}.{1,10}\t\t\t{2,-1}.            {3,-10}", (i + 1), yolcu[i].Durum, (i + 2), yolcu[i + 1].Durum);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("{0,5}.{1,10}\t\t\t{2,-1}.            {3,-10}", (i + 1), yolcu[i].Durum, (i + 2), yolcu[i + 1].Durum);
                }
                

            }   
        }

    }
}