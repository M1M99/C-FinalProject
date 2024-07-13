using System.Text.Json;

namespace FinalProjectC_.UserPanel.Methods
{
    public class ControlPanel
    {
        public static List<User> users = new List<User>();
        public static void RegisterFUser(string Name1, string PassWord1)
        {
            if (UserExists(Name1))
            {
                Console.WriteLine("Username already exists. Please TRY other With Username");
                Thread.Sleep(2000);
                Console.Clear();
                return;
            }

            User user = new()
            {
                Name = Name1,
                Password = PassWord1
            };
            users.Add(user);

            var tr = JsonSerializer.Serialize(users);
            File.WriteAllText("user.json", tr);
            //using (StreamWriter sw = File.AppendText("user.json"))
            //{
            //    sw.WriteLine(tr);
            //}
            Console.WriteLine("Data saved");
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void ForLogin(string name, string password)
        {
            bool log = false;
            if (File.Exists("user.json"))
            {
                var l = File.ReadAllText("user.json");
                users = JsonSerializer.Deserialize<List<User>>(l);
                //File.WriteAllText("user.json", tr);
                //using (StreamReader sr = new StreamReader("user.json"))
                //{
                //    string jsonString = sr.ReadToEnd();
                //    List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);
                //}

                foreach (var x in users)
                {
                    if (name == x.Name && password == x.Password)
                    {
                        Console.WriteLine("Successful Login !");
                        Thread.Sleep(2100);
                        log = true;
                        MenuForUserControlP.ShowCategory(name, password);
                        return;
                    }
                }

                if (log == false)
                {
                    Console.WriteLine("False Name Or PassWord");
                }
            }
            else
            {
                Console.WriteLine("Evvelce Register Ol !");
            }
        }


        public static bool ChangePassword(string name, string currentPassword, string newPassword)
        {
            {
                bool success = false;

                if (File.Exists("user.json"))
                {
                    var jsonData = File.ReadAllText("user.json");
                    users = JsonSerializer.Deserialize<List<User>>(jsonData);

                    foreach (var user in users)
                    {
                        if (user.Name == name && user.Password == currentPassword)
                        {
                            user.Password = newPassword;
                            success = true;
                            Console.WriteLine("Password changed successfully!");
                            break;
                        }
                    }

                    if (success)
                    {
                        var updatedJsonData = JsonSerializer.Serialize(users);
                        File.WriteAllText("user.json", updatedJsonData);
                    }
                    else
                    {
                        Console.WriteLine("User not found or incorrect current password.");
                    }
                }
                else
                {
                    Console.WriteLine("No user data found. Please register first.");
                }

                Thread.Sleep(2000);
                Console.Clear();
                return success;
            }
        }
        private static bool UserExists(string username)
        {
            foreach (var user in users)
            {
                if (user.Name == username)
                {
                    return true;
                }
            }
            return false;
        }
    }
}