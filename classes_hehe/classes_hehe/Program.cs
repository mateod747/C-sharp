using System;

namespace classes_hehe
{
    class Burger
    {
        public string Make { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Burger cheeseBurger = new Burger();
            cheeseBurger.Make = "Burger!";
            cheeseBurger.Type = "Cheese";
            cheeseBurger.Price = 2;

            Console.WriteLine("{0} {1} {2}", cheeseBurger.Make, cheeseBurger.Type, "$" + cheeseBurger.Price);

            if(IsBurgerMoreExpensiveThanTwoDollars(cheeseBurger))
            {
                Console.WriteLine("It's more expensive than $2");
            } else
            {
                Console.WriteLine("It's not more expensive than $2");
            }
        }

        private static bool IsBurgerMoreExpensiveThanTwoDollars(Burger burger)
        {
            if (burger.Price > 2) return true;
            else return false;
        }
    }   
}
