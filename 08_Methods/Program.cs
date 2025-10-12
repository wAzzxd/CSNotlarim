﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            //()
            //Geriye değer döndürmeyen metotlar
            //Customer-->Listele, ekle, sil, güncelle
            //Void

            //void CustomerList()    
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            ////Bu şekilde kalırsa ekrana hiç bir şey yazdırmaz

            //CustomerList();   //Çağırdık, kilitli bir sembol varsa private bir metottur.

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);

            //}

            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);


            //}

            //WriteMethod("Mehmet Yıldırım");



            //void CustomerCard(string customerName, string customerSurname)
            //{
            //    Console.WriteLine("Müşteri: "+customerName+" "+customerSurname);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result=number1 + number2+number3 ;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion


            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";   //Buse Yıldızın bir kaşılığı yok o yüzden bir şey yazdırmaz.
            //}
            //CustomerName();



            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name +" "+ surname;
            //}

            //Console.WriteLine(StudentCard());






            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor) 
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;


            //    return cardInfo;
            //}


            //string x, y, z;  //Dışardan almadan da yapabiliriz.

            //Console.Write("Ülke adını giriniz: ");
            //x= Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y= Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı + Beyaz")); //Elle girdik.

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //int Sum(int number1, int number2) 
            //{
            //    int result=number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));

            #endregion

            #region Örnek Uygulama

            //string Result(string student, int exam1,  int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " İsimli öğrenci Dersi Geçti" + " Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " İsimli öğrenci Sınavdan Kaldı" + " Ortalama: " + result;
            //    }

            //}

            //Console.WriteLine(Result("Ali", 25,58,39));
            //Console.WriteLine(Result("Ahmet", 75,49,90));

            #endregion

            Console.Read();
        }
    }
}
