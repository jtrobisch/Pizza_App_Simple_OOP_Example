using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaOOP
{
    public enum pizzaSize
    {
        Small,Medium,Large
    };

    class Program
    {

        static List<Pizza> MyListOfPizzas = new List<Pizza>(); //Pizza Array - Stores Pizza Objects

        static void Main(string[] args)
        {
            while (true)
            {//start of loop
                Console.Clear();
                Console.WriteLine("Choose an item;");
                Console.WriteLine("A) Add Pizza");
                Console.WriteLine("B) Remove Pizza");
                Console.WriteLine("C) Show Order");
                Console.WriteLine("D) Total Order");
                Console.WriteLine("E) Exit");
                String choice = Console.ReadLine();
                choice = choice.ToLower();
                if (choice.Equals("a"))
                {
                    addPizza();
                }
                else if (choice.Equals("b"))
                {
                    removePizza();
                }
                else if (choice.Equals("c"))
                {
                    viewPizzas();
                }
                else if (choice.Equals("d"))
                {
                    TotalPizzasPrice();
                }
                else if (choice.Equals("e"))
                {
                    break;
                }
            }//end of loop

        }

        static void addPizza()
        {
            String t_topping = "";
            pizzaSize t_sizeChosen = pizzaSize.Medium;
            double t_price = 0;

            Console.Clear();
            Console.WriteLine("Add Pizza;\n");
            Console.WriteLine("PRICE CHART: Standard Price Shown for Medium - Small -10%, Large +10%\n");
            Console.WriteLine("1.CHEESE & TOMATO - Italian - style six - cheese blend - £7.50");
            Console.WriteLine("2.BBQ CHICKEN - Chargrilled chicken, barbeque sauce, bacon, onions - £7.90");
            Console.WriteLine("3.Meat Feast - Ham, pepperoni, sausage, bacon, spicy beef - £8.10");
            Console.WriteLine("4.PIRI PIRI CHICKEN -Chilli pepper sauce, chargrilled chicken - £8.80");
            Console.WriteLine("5.HAWAII - Ham, pineapple, mushrooms - £8.90");
            Console.WriteLine("6.MEDITERRANEAN - Chorizo, Italian - style sausage, jalapeno sausage - £9.50");
            Console.WriteLine("7.THE MEXICAN - Jalapeno peppers, red peppers, spicy beef, onions - £9.70");
            Console.WriteLine("8.THE WORKS - Pepperoni, sausage, ham, mushrooms, green peppers - £9.90");            String choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    t_topping = "CHEESE & TOMATO";
                    t_price = 7.50;
                break;
                case "2":
                    t_topping = "BBQ CHICKEN";
                    t_price = 7.90;
                break;
                case "3":
                    t_topping = "Meat Feast";
                    t_price = 8.10;
                break;
                case "4":
                    t_topping = "PIRI PIRI CHICKEN";
                    t_price = 8.80;
                break;
                case "5":
                    t_topping = "HAWAII";
                    t_price = 8.90;
                break;
                case "6":
                    t_topping = "MEDITERRANEAN";
                    t_price = 9.50;
                break;
                case "7":
                    t_topping = "THE MEXICAN";
                    t_price = 9.70;
                break;
                case "8":
                    t_topping = "THE WORKS";
                    t_price = 9.90;
                break;

            }

            Console.WriteLine("\nEnter Pizza Size; [S] - [M] - [L]");
            String choice2 = Console.ReadLine();
            choice2 = choice2.ToUpper();
            switch (choice2)
            {
                case "S":
                    t_price = t_price * 0.9;
                    t_sizeChosen = pizzaSize.Small;
                break;
                case "M":
                    t_sizeChosen = pizzaSize.Medium;
                break;
                case "L":
                    t_price = t_price * 1.1;
                    t_sizeChosen = pizzaSize.Large;
                break;
            }


            Pizza MyNewPizzaObject = new Pizza(); //create a new pizza object
            MyNewPizzaObject.price = t_price; //set properties
            MyNewPizzaObject.size = t_sizeChosen;
            MyNewPizzaObject.topping = t_topping;
            MyListOfPizzas.Add(MyNewPizzaObject); //add to global list array
            Console.Clear();
            Console.WriteLine("\nPizza added to order.");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        static void removePizza()
        {
            Console.Clear();
            Console.WriteLine("Remove Pizza;\n");
            int i = 0;
            foreach (Pizza item in MyListOfPizzas)
            {
                Console.WriteLine("[{0}] Pizza Type: {1} - Pizza Size: {2} - Pizza Price: {3:c}", i, item.topping, item.size, item.price);
                i++;
            }
            Console.WriteLine("\nEnter ID of Pizza to remove;\n");
            int id = int.Parse(Console.ReadLine());
            MyListOfPizzas.RemoveAt(id);
            Console.WriteLine("\nPizza removed.");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        static void viewPizzas()
        {
            Console.Clear();
            Console.WriteLine("View Pizzas;\n");
            int i = 0;
            foreach (Pizza item in MyListOfPizzas)
            {
                Console.WriteLine("[{0}] Pizza Type: {1} - Pizza Size: {2} - Pizza Price: {3:c}",i,item.topping, item.size, item.price);
                i++;
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        static void TotalPizzasPrice()
        {
            Console.Clear();
            Console.WriteLine("Total Pizza Order Price;\n");
            int i = 0;
            double total = 0;
            foreach (Pizza item in MyListOfPizzas)
            {
                Console.WriteLine("[{0}] Pizza Type: {1} - Pizza Size: {2} - Pizza Price: {3:c}", i, item.topping, item.size, item.price);
                total = total + item.price;
                i++;
            }
            Console.WriteLine("\nOrder Total; {0:c}",total);
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }

    class Pizza //blueprint of a pizza object
    {
        public string topping { get; set; }
        public pizzaSize size { get; set; } 
        public double price { get; set; }
    }
}
