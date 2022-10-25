using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab= {1,9,21,23};
            Console.WriteLine("entrer lenombre : ");
            int num = int.Parse(Console.ReadLine());
            int dim=int.Parse(Console.ReadLine());

            addNum(tab, num);

        }
        static void affich(in[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i])
                {
                    Console.WriteLine(tab[i].ToString());
                }
                else
                {
                    return;
                }
                

            }
        }
        static void ajoutNum(int[] tab,int num)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i]>num)
                {
                    Array.Resize(ref tab, tab.Length + 1);
                    for (int n = tab.Length; n >i; n--)
                    {
                        tab[n] = tab[n - 1];
                    }
                    tab[i] = num;
                    return;

                }
            }

        }

    }
}
