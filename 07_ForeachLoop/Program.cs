using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Foreach Kullanımı 

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //       Console.WriteLine(x);                                          // Her şehri teker teker sırayla yazdırır.
            //}



            //int[] numbers = { 5, 7895, 13, 89, 73, 453, 547, 359, 15, 31 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //int[] numbers = { 5, 7895, 13, 89, 73, 453, 547, 359, 15, 31, 88, 12, 164, 846, 540 };

            //foreach (int number in numbers)
            //{                                                                             //Sadece 2 ye bölünenleri yazdırıyor.
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}




            //int[] numbers = { 51, 623, 272, 622, 794, 2438, 2399, 23447 };
            //int total = 0;

            //foreach (int i in numbers)                                 //Tüm sayıları toplayıp yazdırır.
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);





            #endregion

            #region List kullanımı

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}




            #endregion

            #region Foreach Uygulamaları

            //Bir kelimenin harflerini ayırıp yazıyor
            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();    
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan aldık.
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var? ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklıyacak diziler.
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. Öğrencinin İsmini Giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav sonucu alma işlemi.

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value; //Notları topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult/3;
            }

            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları.
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi başarıyla geçmiştir!");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçememiştir.");
                }
                Console.WriteLine("---------------------------------------");
            }





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            #endregion



            Console.Read();
        }
    }
}
