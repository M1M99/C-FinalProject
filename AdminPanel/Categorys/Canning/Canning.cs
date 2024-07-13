using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectC_.AdminPanel.Categorys.Canning
{
    public class Canning
    {
        public Canning() { }

        public Canning(string name, decimal price,  string description, decimal kcal, DateTime lastUseDate)
        {
            id = _id++;
            Price = price;
            NameOfProduct = name;
            Description = description;
            Kcal = kcal;
            LastUseDate = lastUseDate;
        }
        public int id { get; set; }
        public int _id { get; set; } = 1;
        public decimal Price { get; set; }
        public string NameOfProduct { get; set; }
        public string Description { get; set; }
        public decimal Kcal { get; set; }
        public DateTime LastUseDate { get; set; }

        public Dictionary<string, List<Canning>> CanningList = new Dictionary<string,List<Canning>>();

        public override string ToString()
        {
            return $"{id} {NameOfProduct} {Description} {Kcal} {LastUseDate.ToString("dd.MM.yyyy")}  Price : {Price}";
        }
        public void ForCanningL()
        {
            List<Canning> cannings = new List<Canning>()
            {
                new("Canned Fish",8,"Canned Salmon",200,DateTime.Now.AddYears(1)),
                new("Canned Meat",7,"Canned Meat",220,DateTime.Now.AddYears(1)),
                new("Canned Corn",4,"Canned Vagetable",120,DateTime.Now.AddYears(1)),
                new("Canned Fish2",7,"Canned Tuna",270,DateTime.Now.AddYears(1)),
            };
            CanningList.Add("Canned Foods",cannings);
            foreach (var item in CanningList) {
                Console.WriteLine($"Category: {item.Key}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine(item2);
                }
            }
        }
    }
    
}
