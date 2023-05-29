using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz yinelemeli
            //3^4 = 3*3*3*3

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result*3;
            }
            Console.WriteLine(result);

            Islemler intence = new();
            Console.WriteLine(intence.Expo(3,4));

            //Ectension Metotlar
            string ifade = "Muhammed Salih";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpace());
            Console.WriteLine(ifade.MakeUpCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi ={9,3,6,2,1,5,0};
            dizi.ShortArray();
            dizi.EkranaYazdir();
            
            int sayi = 5;
            sayi.isEvenNumber();
            Console.WriteLine(sayi.isEvenNumber());
            Console.WriteLine(ifade.GetFirstCharacter());

        }
        
    }
    public class Islemler
        {
            public int Expo(int sayi, int üs)
            {
                if (üs<2) 
                {
                    return sayi;
                }
                return Expo(sayi,üs-1)*sayi;
            }
            //Expo(3,4)
            //Expo(3,3)*3;
            // Exception(3,2)*3*3;
            // Exception(3,1)*3*3*3;
            // 3*3*3*3=3^4;
        }
        public static class Extension{
            public static bool CheckSpaces(this string param)
            {
                return param.Contains(" ");
            }

            public static string RemoveWhiteSpace(this string param){
                string[] dizi = param.Split(" ");
                return string.Join("",dizi);
            }
            public static string MakeUpCase(this string param)
            {
                return param.ToUpper();
                
            }
            public static string MakeLowerCase(this string param)
            {
                return param.ToLower();
                
            }
            public static int[] ShortArray(this int[] param)
            {
                Array.Sort(param);
                return param;
            }
            public static void EkranaYazdir(this int[] param)
            {
                foreach (var item in param)
                {
                    Console.Write(item+", ");
                }
            }
            public static bool isEvenNumber(this int param)
            {
                return param%2==0;
            }
            public static string GetFirstCharacter(this string param)
            {
                return param.Substring(0,1);
            }
        }
}