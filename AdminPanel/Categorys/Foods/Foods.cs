namespace FinalProjectC_.AdminPanel.Categorys.Foods
{
    public class Foods
    {
        public Foods()
        {
            id = _id++;
            Food = new Dictionary<string, List<Foods>>();
        }
        public Foods(string name, decimal price, decimal kcal, decimal protein, string description,int count)
        {
            Count = count;
            id = _id++;
            Name = name;
            Price = price;
            Description = description;
        }
        public Foods(string name, decimal price, decimal kcal, decimal protein,int count)
        {
            Count = count;
            id = _id++;
            Name = name;
            Price = price;
        }
        public int id { get; set; }
        public static int _id { get; set; } = 1;
        public decimal Kcal { get; set; }
        public decimal ProteinAmount { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public Dictionary<string, List<Foods>> Food = new Dictionary<string, List<Foods>>();
        public override string ToString()
        {
            var Result = $"{id} {Name} {Kcal} {ProteinAmount} {Price}";
            if (!string.IsNullOrEmpty(Description))
            {
                Result += $"Description {Description}";
            }
            return Result;
        }

        public void MethodsForFood()
        {
            List<Foods> Fruits = new List<Foods>()
            {
                new Foods("Apple", 2.1m, 52, 3, "Iran Apple",1),
                new Foods("Orange", 2.1m, 49, 5, "Orange Indigenous",123),
                new Foods("Patato", 2.1m, 160, 7, "Vegetable",1232),
                new Foods("Pear", 2.1m, 100, 5, "Pear Fruit", 12),
                new Foods("Tomato", 2.1m, 13, 2,"Vegetable", 12),
                new Foods("Plum", 2, 60, 3, "Plum Product",90)
            };
            List<Foods> Bread = new List<Foods>()
            {
                new Foods("White Bread", 1, 290, 7, 12),
                new Foods("Black Bread", 1.1m, 250, 9, 12),
                new Foods("Lavash", 1.5m, 190, 5,8),
                new Foods("Tandir", 0.9m, 210, 6,4),
                new Foods("White Bread(Cutted)", 2, 290, 7, "Sliced White Bread", 12)
            };
            List<Foods> DairyProducts = new List<Foods>()
            {
                new Foods("Milk", 2, 62, 3,2),
                new Foods("Yogurt", 3, 59, 5, 12),
                new Foods("Butter", 5, 460, 7,23),
                new Foods("Cheese", 7.1m, 300, 5,89),
            };
            List<Foods> MeatFishChickenProducts = new List<Foods>()
            {
                new Foods("Meat", 2, 150, 26, 12),
                new Foods("Chicken", 3, 165, 25,41),
                new Foods("Salmon", 5, 140, 23, 12),
                new Foods("Lamb", 7.1m, 170, 25,41),
                new Foods("Trout", 7.1m, 150, 27,61),
            };
            List<Foods> Drink = new List<Foods>()
            {
                new Foods("Water", 1, 0, 0, 12),
                new Foods("Mineral Water", 1, 0, 0, 12),
                new Foods("Energy Drink", 3, 100, 6, 12),
                new Foods("Tea", 2, 4, 0, 12),
                new Foods("Coffee", 3, 8, 0, 12),
            };
            List<Foods> OIL = new List<Foods>()
            {
                new Foods("Olive Oil", 16, 700, 0, 12),
                new Foods("Cow Oil", 20, 850, 0, 12),
                new Foods("Vegetable Oil", 15, 500, 0,91),
                new Foods("Peanut Oil", 23, 700, 6,78),
                new Foods("Sunflower Oil", 15, 670, 0, 41),
            };
            Food.Add("Fruits", Fruits);
            Food.Add("Drink", Drink);
            Food.Add("Bread", Bread);
            Food.Add("MeatProducts", MeatFishChickenProducts);
            Food.Add("Milk Products", DairyProducts);
            Food.Add("Oil", OIL);
        }
    }
}