namespace PizzaLend
{
    internal static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PizzaTime());
        }
    }

    static class Varibales
    {
        static public string filePath = @"C:\Users\Admin\source\repos\PizzaLend\PizzaLend\users.db";
        static public List<Pizza> pizzas = new List<Pizza>();
        static public string paymentMethod;
    }

    public class Pizza
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public List<string> Addities { get; set; }

        public Pizza(string name, int count, List<string> addities)
        {
            Name = name;
            Count = count;
            Addities = addities;
        }

        public string GetFullPizza()
        {
            string addities_string = string.Empty;

            foreach(string item in Addities) addities_string += item; 

            return $"Название: {Name} количество: {Count} добавки: {addities_string}";
        }
    }
}