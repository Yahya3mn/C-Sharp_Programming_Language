using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisanlar
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> AdveSoyad = new List<string>();
            List<double> Maas = new List<double>();

            for(int i = 0; i < 10;i++) {
                Console.WriteLine($"Lütfen {i+1}. kişinin adını ve soyadını girin:");
                string adSoyad = Console.ReadLine();
                AdveSoyad.Add(adSoyad);

                Console.WriteLine($"Lütfen {i+1}. kişinin maaşını girin :");
                double maas = Convert.ToDouble(Console.ReadLine());
                Maas.Add(maas);
            }
            HesaplaVeSirala(AdveSoyad, Maas);

            Console.WriteLine("Maaşlar ve isimler sıralandı");
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine($"{AdveSoyad[i]}, {Maas[i]}");
            }
        }
        
        static void HesaplaVeSirala(List<string>AdveSoyad, List<double> Maas)
        {
            for(int i = 0; i < 10; i++) {
                double yeniMaas = Maas[i] * 95; //%5 kesinti yapılır
                Maas[i] = yeniMaas;
            }

            //Maaşları ve isimleri sırala
            for (int i = 0; i < 9; i++)
            {
                for(int j = i + 1; j < 10; j++)
                {
                    if (Maas[i] < Maas[j]) {
                        double temp = Maas[i];
                        Maas[i] = Maas[j];
                        Maas[j] = temp;

                        string tempAd = AdveSoyad[i];
                        AdveSoyad[i] = AdveSoyad[j];
                        AdveSoyad[j] = tempAd;
                    }
                }
            }
        }

    }
   
    }

