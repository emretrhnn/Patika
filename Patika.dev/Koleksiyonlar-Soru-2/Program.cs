
using System;
using System.Collections;

namespace degisken{

    class Program{
        static void Main(string[] args){
            
            int[] sayilar = new int[20];
            int[] enKucukUcSayi = new int[3];
            int[] enBuyukUcSayi = new int[3];
            int enKucuklerOrtalama, enKucuklerToplam = 0;
            int enBuyuklerOrtalama, enBuyuklerToplam= 0;

            for(int i=0; i<20; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = n;
            }

            Array.Sort(sayilar);
            for(int j=0; j<3 ; j++)
            {
                enKucukUcSayi[j]=sayilar[j];
                enKucuklerToplam += enKucukUcSayi[j];
            }
            Console.WriteLine("En küçük sayılar:" + 
            enKucukUcSayi[0] + "," + enKucukUcSayi[1] + "," + enKucukUcSayi[2]);
            
            
            Array.Reverse(sayilar);
            for(int k=0; k<3 ; k++)
            {
                enBuyukUcSayi[k]=sayilar[k];
                enBuyuklerToplam += enBuyukUcSayi[k];
            }
            Console.WriteLine("En büyük sayılar:" + 
            enBuyukUcSayi[0] + "," + enBuyukUcSayi[1] + "," + enBuyukUcSayi[2]);


            enKucuklerOrtalama = enKucuklerToplam/3;
            Console.WriteLine("En kücük 3 sayının ortalaması: " + enKucuklerOrtalama);

            enBuyuklerOrtalama = enBuyuklerToplam/3;
            Console.WriteLine("En büyük 3 sayının ortalaması: " + enBuyuklerOrtalama);
            
            Console.WriteLine("Ortalamalar toplamı: " +(enKucuklerOrtalama+enBuyuklerOrtalama));

            
        }
    }
}