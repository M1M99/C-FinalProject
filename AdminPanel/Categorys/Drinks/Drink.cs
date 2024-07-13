namespace FinalProjectC_.AdminPanel.Categorys.Drinks
{
    public class Drink
    {
        public Drink(string type, string name, decimal price, int Count)
        {
            this.Count = Count;
            id = _id++;
            Type = type;
            Name = name;
            Price = price;
        }

        public int id { get; set; }
        public static int _id { get; set; } = 1;
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public static Dictionary<string, List<Drink>> DrinkF = new Dictionary<string, List<Drink>>();

        public override string ToString()
        {
            return $"{id} {Type} {Name} {Price}";
        }
        public Drink()
        {
        }
        public static void methods()
        {
            List<Drink> drinks = new List<Drink>()
            {
                new("Non-alcoholic","Carbonated Water",2,12),
                new("Non-alcoholic","Water",2,82),
                new("Non-alcoholic","Energy Drink",4,90),
                new("Non-alcoholic","Juice",4,891),
                new("Non-alcoholic","Tea",3,81),
                new("Non-alcoholic","Coffee",3,44)
            };
            DrinkF.Add("Drinks", drinks);
        }
    }
}
