using System.Numerics;

namespace taskbessa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persondetails>persondetails = new List<Persondetails>();
            leo hamza = new leo() ;
            int chose;
            while (true)
            {
                Console.WriteLine($"1-Add User \n2-Update Data of User \n3-Delete User\n4-Print All User");
                string input = Console.ReadLine();


                if (int.TryParse(input, out chose))
                {
                    if (chose == 1)
                    {
                        hamza.create(persondetails);
                    }
                    else if (chose == 2)
                    {
                        hamza.update(persondetails);
                    }
                    else if (chose == 3)
                    {
                        hamza.remove(persondetails);
                    }
                    else if (chose == 4)
                    {
                        hamza.PrintAllUser(persondetails);
                    }
                    else
                    {
                        Console.WriteLine("You Enter Wrong Number!!");

                    }

                }
                else
                {
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.WriteLine("==========================================================");
                }
            }
        }

    }

    class leo
    {


        public void create(List<Persondetails> persondetails)
        {
            Console.WriteLine("___________________________create a new user_______________________");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();

            Persondetails person = new(name, email, phone);
            persondetails.Add(person);

            Console.WriteLine($"============================User Information you Enterd================================");
            Console.WriteLine($"Name: {person.name}");
            Console.WriteLine($"Email: {person.email}");
            Console.WriteLine($"Phone Number: {person.phone}");
        }

        public void remove(List<Persondetails>persondetails)
        {
            Console.Write("Enter User Phone Number you want to remove: ");
            string phone = Console.ReadLine();
            Persondetails Foundeduser = persondetails.FirstOrDefault(x => x.phone == phone);
            if (Foundeduser != null)
            {
                persondetails.Remove(Foundeduser);
                Console.WriteLine($"you delete user name : {Foundeduser.name}");
            }
            else
            {
                Console.WriteLine("No user Like this");
            }


        }
        public void update(List<Persondetails> persondetails)
        {
            Console.Write("Enter User Phone Number you want to Edit: ");
            string phone = Console.ReadLine();
            Persondetails Foundeduser = persondetails.FirstOrDefault(x => x.phone == phone);

            if (Foundeduser == null)
            {
                Console.WriteLine("No user Like this to edit");
            }
            else
            {
                Console.Write("1-Edit Name: \n2-Edit Email: \n3-Edit  \n");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.Write("Enter Edited Name: ");
                    string newName = Console.ReadLine();
                    Foundeduser.name = newName;
                }
                else if (num == 2)
                {
                    Console.Write("Enter Edited email: ");
                    string newEmail = Console.ReadLine();
                    Foundeduser.email = newEmail;

                }
                else if (num == 3)
                {
                    Console.Write("Enter Edited phone: ");
                    string newPhone = Console.ReadLine();
                    Foundeduser.phone = newPhone;

                }

            }
        }
        public void PrintAllUser(List<Persondetails> persondetails)
        {
            if (persondetails.Count==0)
                Console.WriteLine("no user found");
                Console.WriteLine("_______________________________________________________________________")
            else
            {

                Console.WriteLine($"============================ All User================================");
                int count = 1;

                foreach (var item in persondetails)
                {
                    {
                        Console.WriteLine($"User {count}");
                        Console.WriteLine($"Name: {item.name}");
                        Console.WriteLine($"Email: {item.email}");
                        Console.WriteLine($"Phone Number: {item.phone}");
                        count++;

                    }
                }
                Console.WriteLine("____________________________________________________________");


            }
            
        }

    }


        class Persondetails
        {
            public string name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }

            public Persondetails(string name,string email ,string phone )
            {
                this.name = name;
                this.email = email;
                this.phone = phone;
            }
        }
    
}
