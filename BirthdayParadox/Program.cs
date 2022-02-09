using System;

namespace BirthdayParadox
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[,] matris = new int[5,15];
            String[] hafta = { "Pazatesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            for (int i = 0; i < 5; i++)
            { //kişi sayısı
                int[] kisi_sayisi = { 2, 3, 5, 10, 20 };
                Console.WriteLine();
                Console.WriteLine(kisi_sayisi[i] + "kişiik grup için veriler:");
                for (int j = 0; j < 15; j++)
                { //deney sayısı
                    int[] haftanin_gunleri = { 0, 0, 0, 0, 0, 0, 0 };
                    Console.WriteLine(j + 1 + ". deney");
                    int toplam = 0;
                    for (int k = 0; k < kisi_sayisi[i]; k++)
                    {
                        int sayi = generator.Next(7); //o ile 6 arasında değer üretecek
                        haftanin_gunleri[sayi] += 1;
                    }
                    Console.WriteLine("haftanın günlerindeki çakışma sayıları:");
                    int a = 0;
                    foreach (int element in haftanin_gunleri)
                    { // çakışma sayısını hesaplar
                        if (element == 0)
                        {
                            Console.WriteLine(hafta[a] + ":" + element + " çakışma vardır");
                        }
                        else
                        {
                            toplam += element - 1;
                            Console.WriteLine(hafta[a] + ":" + (element - 1) + " çakışma vardır");
                        }
                        a += 1;
                    }
                    matris[i,j] = toplam;
                }
            }
            Console.WriteLine("15 deneyde ve 5 kişide toplam çakışma sayıları");
            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine((b + 1) + ".kişi için:");
                for (int y = 0; y < 15; y++)
                {
                    Console.WriteLine(matris[b,y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}