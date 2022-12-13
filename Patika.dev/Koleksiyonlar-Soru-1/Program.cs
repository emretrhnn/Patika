
using System.Collections;

namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList number = new ArrayList();
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();

            int asalSayac = 0;
            int asalOlmayanSayac = 0;
            int asalOrtalama = 0;
            int asalOlmayanOrtalama = 0;
            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            Console.WriteLine("20 Tane Sayı Giriniz.");

            for(int i = 0;i<20;i++)
            {
                try
                {
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if(sayi<=0)
                    {
                        Console.WriteLine("Pozitif sayı giriniz.");
                    }
                    else
                    {
                        number.Add(sayi);
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Girilen değer bir sayi olmalı");
                }
            }

            foreach(var s in number)
            {
                if(asalKontrol(Convert.ToInt32(s))==true)
                {
                    asal.Add(s);
                    asalSayac++;
                    asalToplam = asalToplam + Convert.ToInt32(s);
                }
                else
                {
                    asalOlmayan.Add(s);
                    asalOlmayanSayac++;
                    asalOlmayanToplam = asalOlmayanToplam + Convert.ToInt32(s);
                }
            }

            asalOrtalama = asalToplam/asalSayac;
            asalOlmayanOrtalama = asalOlmayanToplam/asalOlmayanSayac;

            asal.Sort();
            asal.Reverse();
            asalOlmayan.Sort();
            asalOlmayan.Reverse();

            Console.Write("Asal Sayilarin büyükten kücüge dogru siralanmasi: ");
            foreach(var item in asal)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Asal Sayilar dizisinin eleman sayisi:" + asalSayac);
            Console.WriteLine("Asal Sayilar dizisinin ortalamasi:" + asalOrtalama);

            Console.Write("Asal Olmayan Sayilarin büyükten kücüge dogru siralanmasi: "); //asalOlmayan ArrayList'ini yazdırma
            foreach (var item in asalOlmayan)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Asal Olmayan Sayilar dizisinin eleman sayisi:" + asalOlmayanSayac);
            Console.WriteLine("Asal Sayilar dizisinin ortalamasi:" + asalOlmayanOrtalama);
        }

        public static bool asalKontrol(int sayi)
        {
            int sayac = 0;
            bool asal;
            int i;

            for(i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
            }

            if (sayac == 2)
            {
                asal = true;
            }

            else
            {
                asal = false;
            }

            return asal;
        }
    }
}
