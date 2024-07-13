using FinalProjectC_.AdminPanel;
using FinalProjectC_.AdminPanel.Categorys.Clothers;
using FinalProjectC_.AdminPanel.Categorys.Drinks;
using FinalProjectC_.AdminPanel.Categorys.Electronics;
using FinalProjectC_.AdminPanel.Categorys.Foods;

namespace FinalProjectC_.UserPanel.Methods
{
    public class MenuForUserControlP
    {
        public static int _id = 1;
        public static void ShowCategory(string a, string b)
        {
        ShowC:
            Console.Clear();
            Console.Write($"1. Category\n2. Profil\n3. Cart\n4. Log Out\n");
            var t = Console.ReadKey();
        ShowD:
            switch (t.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine("1. Electronic\n2. Fooods\n3. Clothers\n4. Drinks\n5. Log Out\n6. Geri\n7. Add\n8. Daily Income");
                    var t1 = Console.ReadKey();
                    switch (t1.Key)
                    {
                        case ConsoleKey.D8:
                            if (AmountForCard.forAdmin > 0)
                            {
                                Console.Clear();
                                Console.WriteLine($"Income - {AmountForCard.forAdmin} {DateTime.Now.ToString("dd.MM.yyyy")}");
                                Thread.Sleep(2000);
                                goto ShowC;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("There Was No Shopping");
                                Thread.Sleep(1900);
                                goto ShowD;
                            }
                            break;
                        case ConsoleKey.D7:
                            Dictionary<string, List<Electronic>> a12 = new();
                            Electronic.ForAdminAddProduct(a12);
                            Electronic.ListProducts(a12);
                            break;
                        case ConsoleKey.D1:
                        k:
                            Electronic electronic1 = new();
                            electronic1.MethodForList();
                            Console.Clear();
                            var t12 = electronic1.electlist;
                            electronic1.key2(t12);
                        k1:
                            Console.WriteLine("Enter ID:");
                            try
                            {
                                int idInput = Convert.ToInt32(Console.ReadLine());
                                electronic1.ProcessItems(electronic1.electlist.Values, i => i.Id == idInput, f => f.Price, f => f.Model,f => f.count);
                                goto ShowD;
                            }
                            catch { goto k1; }
                        case ConsoleKey.D2:
                            Console.Clear();
                            Foods foods = new Foods();
                            foods.MethodsForFood();
                            Electronic electronic2 = new Electronic();
                            var food = foods.Food;
                            electronic2.key2(food);
                            Console.WriteLine("Enter ID:");
                        h:
                            int idInput1 = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                electronic2.ProcessItems(foods.Food.Values, f => f.id == idInput1, f => f.Price, f => f.Name,f=>f.Count);
                            }
                            catch { goto h; }
                            goto ShowD;
                        case ConsoleKey.D3:
                            Console.Clear();
                            Clothers clothers = new Clothers();
                            clothers.Lists();
                            var clotherss = clothers.clothers;
                            Electronic electronic3 = new Electronic();
                            electronic3.key2(clotherss);
                            Console.WriteLine("Enter ID:");
                        j:
                            int idInput2 = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                electronic3.ProcessItems(clothers.clothers.Values, f => f.id == idInput2, f => f.Price, f => f.Name,f=>f.Count);
                            }
                            catch (Exception ex) { goto j; };
                            goto ShowD;
                        case ConsoleKey.D4:
                            Console.Clear();
                            Drink.methods();
                            var drink = Drink.DrinkF;
                            Electronic electronic4 = new Electronic();
                            electronic4.key2(drink);
                            Console.WriteLine("Enter ID:");
                        l:
                            try
                            {
                                int idInput3 = Convert.ToInt32(Console.ReadLine());
                                electronic4.ProcessItems(Drink.DrinkF.Values, f => f.id == idInput3, f => f.Price, f => f.Name,f=>f.Count);
                            }
                            catch (Exception ex) { goto l; };
                            goto ShowD;
                        case ConsoleKey.D5:
                            Console.Clear();
                            MainMenu();
                            break;
                        case ConsoleKey.D6:
                            goto ShowC;
                        default:
                            goto ShowD;
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine($"User Name : {a}\nPassWord : {b}\n1. Change Your PassWord\n2. Change Your UserName\n3. Back");
                    var y = Console.ReadKey();
                    switch (y.Key)
                    {
                        case ConsoleKey.D1:
                        ChangePass:
                            Console.Clear();
                            Console.WriteLine("Enter Your Old PassWord");
                            var OldPass = Console.ReadLine();
                            Console.WriteLine("Enter Your Old Name");
                            var Oldname = Console.ReadLine();
                            Console.Write("Enter New Pass");
                            var newpass = Console.ReadLine();
                            if (OldPass == b)
                            {
                                ControlPanel.ChangePassword(Oldname, OldPass, newpass);
                            }
                            else
                            {
                                Console.WriteLine("False Password Try Again ! ");
                                Thread.Sleep(1500);
                                goto ChangePass;
                            }
                            break;
                        case ConsoleKey.D2:
                        ChangeUserName:
                            Console.Clear();
                            Console.WriteLine("Enter Your PassWord");
                            var Pass1 = Console.ReadLine();
                            if (Pass1 == b)
                            {
                                Console.WriteLine("Enter You New Username");
                                var NewPass = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("False Password Try Again ! ");
                                Thread.Sleep(1500);
                                goto ChangeUserName;
                            }
                            break;
                        case ConsoleKey.D3:
                            Console.Clear();
                            goto ShowC;
                    }
                    break;
                case ConsoleKey.D3:
                    if (AmountForCard.amount > 0)
                    {
                        AmountForCard.ToStr();
                        goto ShowD;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Your Cart Is Empty.");
                        Thread.Sleep(1900);
                        goto ShowC;
                    }
                    //}
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    Console.WriteLine("Logged Out");
                    Thread.Sleep(1900);
                    Console.Clear();
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    goto ShowC;
            }
        }

        public static void MainMenu()
        {
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            var Keys12 = Console.ReadKey();
            switch (Keys12.Key)
            {
                case ConsoleKey.D1:
                    MenuForRegister();
                    break;
                case ConsoleKey.D2:
                    MenuForLogin();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("Exit Is Successful !");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public static void MenuForLogin()
        {
            Console.Clear();
            Console.WriteLine("Enter UserName For Login");
            var name1 = Console.ReadLine();
            Console.WriteLine("Enter PassWord For Login (Access)");
            var PassWord1 = Console.ReadLine();
            ControlPanel.ForLogin(name1, PassWord1);
        }
        public static void MenuForRegister()
        {
            Console.Clear();
            Console.WriteLine("Enter Your Name For Register!");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Your PassWord For Register!");
            var PassWord = Console.ReadLine();
            ControlPanel.RegisterFUser(name, PassWord);
        }
    }
}
