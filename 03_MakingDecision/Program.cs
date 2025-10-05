using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //    {
            //    Console.WriteLine("Şifre Doğru");
            //    }
            //else
            //    {
            //    Console.WriteLine("Şifre Yanlış");
            //    }




            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital= Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country= Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else 
            //{
            //    Console.Write("Hatalı Bilgi");
            //}


            //int sayi;
            //Console.Write("Sayiyi Giriniz: ");
            //sayi =int.Parse(Console.ReadLine());
            //if (sayi == 5)
            //{

            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}



            //int exam1, exam2, exam3, average;
            //string result="--Hatalı Sınav Puanı Girişi";   //92

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());


            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların Ortalaması: " + average);
            //if (average > 0 & average <= 50)
            //{
            //    result = "--Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "--Hala bir umut var";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "--Sonuçlar iyi";
            //}
            //if (average > 84)
            //{
            //    result = "--Sonuçlar çok iyi";
            //}

            //Console.Write(result);   //Değerler değişken olabilir - olabilir o yüzden ya else sonlandır veya başlangıç ataması yap




            //string city;
            //Console.Write("Lütfen Şehir Giriniz: ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}


            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez!");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz!");
            //}


            #endregion

            #region Mod 

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. Sayının 2. sayıya bölümünden kalan: " + result);


            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number=int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayınız çifttir");
            //}
            //else {
            //    Console.WriteLine("Sayınız tektir");
            //}

            #endregion


            #region Char Değişkenler ile Karar Yapıları 

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team=='g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if(team =='b'|team=='B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion


            #region Örnek Proje Uygulaması  


            Console.WriteLine("****** C# Eğitim Kampı Restorant ******");
            Console.WriteLine();
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");

            string menuItem;
            Console.WriteLine("Detayını görmek istediğiniz menü seçin: ");
            menuItem= Console.ReadLine();

            if (menuItem == "1")
            {

            }




                #endregion

                Console.Read();
        }
    }
}
