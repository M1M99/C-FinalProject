using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectC_.AdminPanel.Categorys.Clothers
{
    public class Clothers
    {
        public int  id { get; set; }
        public static int _id { get; set; } = 1;
        public string  Name { get; set; }
        public string  Size { get; set; }
        public string  Material { get; set; }
        public string  Color { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public Dictionary<string, List<Clothers>> clothers = new();
        public Clothers()
        {
            try
            {
                if (id <= clothers.Count)
                {
                    id = _id++;
                }

                else
                {
                    _id = 1;
                    id = _id++;
                }
            }
            catch { }
        }
        public Clothers( string name, string size, string material, string description, decimal price, string color,int count)
        {
            try
            {
                if (id <= clothers.Count)
                {
                    id = _id++;
                }

                else
                {
                    _id = 1;
                    id = _id++;
                }
            }
            catch { };
            Name = name;
            Size = size;
            Material = material;
            Description = description;
            Price = price;
            Color = color;
            Count = count;

        }
        public override string ToString()
        {
            return $"{id} {Name} {Material} {Size} {Color} {Price}";
        }
        public void Lists()
        {
            List<Clothers> clothers1 = new(){
                new("Boot","41","Leather","100 % Real Leather",80,"Black",3),
                new("Hat","Standart","Polyester","Quality Hat",30,"Grey",5),
                new("SweatShirt","41","Cotton","100% Cotton Men SweatShirt",20,"Black",78),
                new("Coat","XL","Leather","100 % Real Leather Coat",70,"Brown",12),
                new("T - Shirt","XL","Cotton","100% Cotton T - Shirt",25,"Black",43),
                new("Shoes","45","Leather","Premium Classic Shoes",225,"Black",53)
            };
            clothers.Add("Clothers",clothers1);
        }
        
    }
}
