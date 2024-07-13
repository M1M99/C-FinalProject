using FinalProjectC_.AdminPanel.Categorys.Drinks;
using Microsoft.VisualBasic;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace FinalProjectC_.AdminPanel.Categorys.Electronics
{
    public static class IDD
    {
        public static int _id = 1;
    }
    public static class list
    {
        public static int _id1 = 1;
        public static List<string> strings = new List<string>();

    }

    public class empty
    {
        public int id;
        public empty()
        {
            try
            {
                if (list._id1 <= list.strings.Count)
                {
                    id = list._id1++;
                }

                else
                {
                    list._id1 = 1;
                    id = list._id1++;
                }
            }
            catch { };

        }
    }



    public class Electronic
    {
        public int Id { get; set; }
        public static int _Id { get; set; } = 1;
        public static int _Idd { get; set; } = 1;
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string CPU { get; set; }
        public int count { get; set; }

        public Dictionary<string, List<Electronic>> electlist { get; set; }
        public Electronic()
        {
            Id = _Id++;
            electlist = new Dictionary<string, List<Electronic>>();
        }
        public Electronic(int idd)
        {
            idd = _Idd++;
        }

        public Electronic(string vendor, string model, int ram, int storage, string color, decimal price, int Count)
        {
            Id = _Id++;
            Vendor = vendor;
            Model = model;
            RAM = ram;
            Storage = storage;
            Color = color;
            Price = price;
            count = Count;
        }

        public Electronic(string vendor, string model, int ram, int storage, string color, decimal price, string cpu, int count)
        {
            Id = _Id++;
            Vendor = vendor;
            Model = model;
            RAM = ram;
            Storage = storage;
            Color = color;
            Price = price;
            CPU = cpu;
            this.count = count;
        }

        public override string ToString()
        {
            var result = $"{Id} {Vendor} {Model}, Storage: {Storage}GB, Color: {Color}, Price: {Price}";
            if (!string.IsNullOrEmpty(CPU))
            {
                result += $", CPU: {CPU}";
            }
            if (RAM != 0)
            {
                result += $", Ram: {RAM}GB";
            }
            return result;
        }


        public static void RemoveItem(string item)
        {
            if (list.strings.Contains(item))
            {
                foreach (var s in a)
                {

                    if (s.Key == item)
                    {
                        AmountForCard.amount -= s.Value;
                    }
                }
                list.strings.Remove(item);
                Console.WriteLine($"{item} Removed from cart.");
                Console.WriteLine($"Your Amount { AmountForCard.amount}");
                return;
            }
            else
            {
                Console.WriteLine($"{item} is not in the cart.");
            }
        }

        public static void ForAdminAddProduct(Dictionary<string, List<Electronic>> electlist)
        {
            Console.Write("Vendor: ");
            var vendor = Console.ReadLine();

            Console.Write("Model: ");
            var model = Console.ReadLine();

            Console.Write("RAM (GB): ");
            int ram;
            while (!int.TryParse(Console.ReadLine(), out ram))
            {
                Console.WriteLine("Invalid");
            }

            Console.Write("Storage (GB): ");
            int storage;
            while (!int.TryParse(Console.ReadLine(), out storage))
            {
                Console.WriteLine("Invalid input.");
            }
            Console.Write("Count: ");
            int Count;
            while (!int.TryParse(Console.ReadLine(), out Count))
            {
                Console.WriteLine("Invalid input.");
            }

            Console.Write("Color: ");
            var color = Console.ReadLine();

            Console.Write("Price: ");
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid input.");
            }

            Console.Write("CPU (optional): ");
            var cpu = Console.ReadLine();

            Electronic newElectronic = new Electronic(vendor, model, ram, storage, color, price, cpu, Count);

            Console.Write("Category Name : ");
            var category = Console.ReadLine();

            if (electlist.ContainsKey(category))
            {
                electlist[category].Add(newElectronic);
            }
            else
            {
                List<Electronic> newList = new List<Electronic> { newElectronic };
                electlist.Add(category, newList);
            }

            Console.WriteLine("Product added successfully!");

        }

        public static void ListProducts(Dictionary<string, List<Electronic>> electlist)
        {
            Console.WriteLine("\nProduct List:");
            foreach (var category in electlist)
            {
                Console.WriteLine($"Category: {category.Key}");
                foreach (var product in category.Value)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }


        List<Electronic> Laptop;
        public void MethodForList()
        {
            List<Electronic> Phones = new List<Electronic>
            {
                new Electronic("Samsung", "Galaxy S20", 8, 128, "Black", 999, "Snapdragon 865",5),
                new Electronic("Apple", "iPhone 12", 6, 256, "Grey", 1100, "A14 Bionic",6),
                new Electronic("Xiaomi", "Mi 11", 12, 256, "Blue", 899.99m, "Snapdragon 888", 4),
                new Electronic("OnePlus", "9 Pro", 12, 256, "Green", 999.99m, "Snapdragon 888",8),
                new Electronic("Apple", "iPhone XS", 4, 128, "Gold", 450, "A12 Bionic", 4),
            };
            List<Electronic> Consoles = new List<Electronic>
            {
                new Electronic("Sony", "PlayStation 5", 16, 825, "White", 900, "AMD Ryzen Zen 2",1),
                new Electronic("Microsoft", "Xbox Series X", 16, 1000, "Black", 1499, "AMD Ryzen Zen 2", 4),
                new Electronic("Nintendo", "Switch", 8, 64, "White", 549, "Custom NVIDIA Tegra", 4),
                new Electronic("Sony", "PlayStation 4", 8, 500, "Black", 450, "AMD Jaguar", 4),
                new Electronic("Sony", "PlayStation 3", 4, 160, "Black", 250, "AMD", 5)
            };
            List<Electronic> Monitors = new List<Electronic>
            {
                new Electronic("Asus", "Gaming", 0, 0, "Black", 1350,12),
                new Electronic("Dell", "U27", 0, 0, "Black", 450,2),
                new Electronic("LG", "27L", 0, 0, "White", 470,12),
                new Electronic("Samsung", "Monitor", 0, 0, "Black", 700,34),
                new Electronic("Asus", "ROG", 0, 0, "Black", 990,1),
            };
            List<Electronic> Tv = new List<Electronic>()
            {
                new ("Sony","Bravia",0,0,"Black",4000, 4),
                new ("Samsung","OLED",0,0,"Grey",1500, 4),
                new ("LG","OLED55",0,0,"Black",2000,8),
                new ("HoffMann","LED55",0,0,"Green",700, 4),
                new ("Xiaomi","2K",0,0,"Black",1400,9),
            };
            List<Electronic> Laptop = new List<Electronic>()
            {
                new ("Asus","ROG",32,1000,"Black",3500,"Ryzen 9", 4),
                new ("Acer","Aspire",8,512,"Grey",1100,"Intel Core i5", 4),
                new ("Asus","Tuf",16,512,"Black",1700,"Ryzen 5", 4),
                new ("Lenovo","Legion",8,512,"Green",1500,"Ryzen 5", 4),
                new ("HP","Pavilion",8,250,"Blue",900,"Intel Core i3", 4),
            };


            electlist.Add("Phones", Phones);
            electlist.Add("Consoles", Consoles);
            electlist.Add("Monitors", Monitors);
            electlist.Add("TV", Tv);
            electlist.Add("Laptops", Laptop);
            Console.WriteLine("Enter Incremeted : ");
        }

        public void key2<T>(Dictionary<string, List<T>> a)
        {
            foreach (var item in a)
            {
                Console.WriteLine($"{IDD._id}. {item.Key}");
                if (IDD._id < a.Count)
                {
                    IDD._id++;
                }
                else
                {
                    IDD._id = 1;
                }
            }
            Console.Write("Choise : ");
            int keys = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.Count; i++)
            {
                var y2 = a.Take(keys).Skip(keys - 1);
                foreach (var item in y2)
                {
                    Console.WriteLine(item.Key);
                    foreach (var item2 in item.Value)
                    {
                        Console.WriteLine(item2);
                    }
                }
                break;
            }
        }
        public static Dictionary<string, decimal> a = new();

        int i;
        public void ProcessItems<T>(IEnumerable<List<T>> items, Func<T, bool> FFunc, Func<T, decimal> priceFunc, Func<T, string> name, Func<T, int> aFunc)
        {
            foreach (var categoryList in items)
            {
                foreach (var item in categoryList)
                {
                    i = aFunc(item);
                    if (FFunc(item))
                    {
                        if (i > 0)
                        {
                            Console.WriteLine($"Product : {name(item)}\nProduct Price : {priceFunc(item)}\nAdded To Cart");
                            list.strings.Add(name(item)!);
                            AmountForCard.amount += priceFunc(item);
                            a.Add(name(item), priceFunc(item));
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("Out Of Stock");
                        }
                    }
                }
            }
            Thread.Sleep(1500);
        }
        public void IncreaseStock(int amount, Electronic a)
        {
            a.count += amount;
            Console.WriteLine($"Stock for {Vendor} {Model} increased by {amount}. Current stock: {count}");
        }
    }
}
