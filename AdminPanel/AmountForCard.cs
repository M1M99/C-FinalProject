using FinalProjectC_.AdminPanel.Categorys.Electronics;
using FinalProjectC_.UserPanel.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectC_.AdminPanel
{
    public static class AmountForCard
    {
        public static decimal amount { get; set; } = 0;
        public static decimal forAdmin { get; set; } = 0;
        public static void ToStr()
        {
            Console.Clear();
            foreach (var i in list.strings)
            {
                empty emptyq = new();
                Console.WriteLine($"{emptyq.id}. {i}");
            }
            Console.WriteLine($"Your Cart {amount}$");
            if (amount > 0)
            {
                try
                {
                    Console.WriteLine("1. Remove Product");
                    Console.WriteLine("2. Pay Cart");
                    Console.Write("Choise : ");
                    int line = int.Parse(Console.ReadLine());
                    if (line == 1)
                    {
                        var text = Console.ReadLine();
                        Electronic.RemoveItem(text);
                    }
                    if (line == 2)
                    {
                    h:
                        Console.Write("Enter Money For Cart : ");
                        int key = Convert.ToInt32(Console.ReadLine());
                        if (key == AmountForCard.amount)
                        {
                            Console.WriteLine("Successfull Amount.");
                            AmountForCard.forAdmin += AmountForCard.amount;
                            AmountForCard.amount = 0;
                            list.strings.Clear();
                            Thread.Sleep(1200);
                            MenuForUserControlP.MainMenu();
                            return;
                        }
                        else if (key > AmountForCard.amount)
                        {
                            Console.WriteLine($"Successful Cart\nResidue : {key - AmountForCard.amount}");
                            AmountForCard.forAdmin += AmountForCard.amount;
                            AmountForCard.amount = 0;
                            list.strings.Clear();
                            Thread.Sleep(1200);
                            MenuForUserControlP.MainMenu();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Not Enough For Cart");
                            Thread.Sleep(2000);
                            goto h;
                        }
                    }
                }
                catch { }
            }
            return;
        }
    }
}
