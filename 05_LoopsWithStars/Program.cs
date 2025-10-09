using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma

            //for (int i = 0; i < 10; i++)
            //{ 
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yanyana 10 Tane Yıldız Oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("* ");
            //}

            #endregion

            #region Yanyana ve Alt Alta 10 Tane Yıldız Oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}




            #endregion

            #region Dik Üçgen (Ters Düz)

            //for (int i = 1; i <= 5; i++) 
            //{
            //    for(int j =1 ; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            //Ters

            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Elmas Şekilleri (2 Dik Üçgen)

            //for (int i = 1; i <= 5; i++)  //ilkte ortadaki sayıyı tanımlıyoruz alt kısım için ise 1 eksiğini yapıyoruz
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i=4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++) 
            //    {  
            //        Console.Write("*"); 
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Baklava Dilimi (???) 

            //int n = 5;        //Baklava diliminin yarı yüksekliği
            //for(int i=1; i <= n; i++)
            //{
            //    for(int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = n - 1; i >= 1; i--)
            //{
            //    for(int j = n - 1;j> 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1;k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++) 
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            //int n = 5;
            //for(int i = n; i >= 1; i--)
            //{
            //    for(int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1;k <= 2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();
        }
    }
}
