using FinalProjectC_.AdminPanel.Categorys.Electronics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectC_.AdminPanel.Categorys
{
    public class Category : Electronic
    {
        public  Dictionary<string, List<Category>> _categories = new Dictionary<string, List<Category>>();
        public static List<Category> _categories1 = new List<Category>();
    }
}
