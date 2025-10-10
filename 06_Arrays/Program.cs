using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //DeğikenTürü [] DiziAdı =new DeğişkenTürü[ElamanSayısı]   

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);





            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);




            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 60;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);   //Değer ataması yapmadığımız bir indes için default değeri 0 kaşımıza çıkıyor.




            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)          //Diziİsmi.length dizinin uzunuluğunu yani eleman sayısını verir      
            //{                                                //colors.length=7 <= olsaydı hata verirdi çünkü elemanlar 0. indesten başlıyor
            //    Console.WriteLine(colors[i]);
            // }


            //int[] numbers = { 4, 99, 60, 125, 635, 488, 520, 7456, 2365, 1120 };
            //int k=0;
            //for ( int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //        k++;
            //    }
            //}

            //Console.Write(k+" Tane 3 sayısına bölünen sayılı bir diziniz vardır");




            //char[] symbols = { 'a', 'b', 'c', '/', '*', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}



            //Dizideki en büyük elemanı bulan uygulama

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);



            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);   //6 yazar

            //int[] numbers = { 10, 34, 56, 23, 9, 345, 29, 40, 71, 123456 };
            //Array.Sort(numbers);                                    //Diziyi Küçükten Büyüğe Sıralar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 10, 34, 56, 23, 9, 345, 29, 40, 71, 123456 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);                                                     //Beraber Kullanınca Diziyi Büyükten Küçüğe Sıralarlar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotlar

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");            //Array.IndexOf(customers, "merve");  dizininIsmi, "aranıcakELaman" 
            //Console.WriteLine(index);                                 // indexe atadığımız içn artık index merve elemanın kaçıncı indeste olduğunu yazdıracak (3)

            //int[] number = { 23, 60, 78, 10, 74, 36, 847 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: "+number.Max()+" Dizinin En Küçük Elemanı: "+number.Min());    //number.Max() ve number.Min() Dizinin max ve min elemanını yazdırır.




            #endregion

            #region Kullanıcıdan Değer Alma 

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");   +i+" " ile uğraşmamak için $ {i+1} yazdık 
            //    cities[i]=Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------");
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}




            //int[] numbers = {10,20, 30,40,50};
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);



            //int[] numbers = { 23, 89, 54, 796, 79, 85, 184, 9842, 541, 26, 48, 94, 12, 80, 777 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("--------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("--------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion



            Console.Read();
        }
    }
}
