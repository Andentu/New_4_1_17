namespace New_4_1_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your color: ");
            string color = new (Console.ReadLine());

            if (color == "red"){
                Console.BackgroundColor = ConsoleColor.Red; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                Console.WriteLine("Your color is " + color);
            }
            
            else if ((color == "yellow") || (color == "orange"))
            {
                Console.BackgroundColor = ConsoleColor.Yellow; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                Console.WriteLine("Your color is " + color);
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                Console.WriteLine("Your color is " + color);
            }
            else if (color == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                Console.WriteLine("Your color is " + color);
            }
            else if (color == "dark blue")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                Console.WriteLine("Your color is " + color);
            }
            else if (color == "violet")
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                Console.WriteLine("Your color is " + color);
            }
            else if (color == "cyan")
            {
                Console.BackgroundColor = ConsoleColor.Cyan; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                Console.WriteLine("Your color is " + color);
            }
            else if (color == "white")
            {
                Console.BackgroundColor = ConsoleColor.White; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                Console.WriteLine("Your color is " + color);
            }
            else
            {
                Console.WriteLine("Sorry color {0} not found in database", color);
            }
            Console.ReadKey();
        }
    }
}