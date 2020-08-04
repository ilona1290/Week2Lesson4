using System;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
        public enum Gender
        {
            m,
            k
        }
        public void Ex1()
        {
            string firstName;
            string lastName;
            int age;
            Gender gender;
            int pesel;
            int numberOfWorker;
        }

        public void Ex2()
        {
            char a = 'a';
            char b = 'b';
            char c = 'c';
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }

        public void Ex3()
        {
            Console.Write("Szerokość: ");
            double width;
            double.TryParse(Console.ReadLine(), out width);
            Console.Write("Wysokość: ");
            double height;
            double.TryParse(Console.ReadLine(), out height);


            double result = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine("Przekątna wynosi: " + Math.Round(result, 2));
        }

        public void Ex4()
        {
            int firstVar;
            float secondVar;
            string thirdVar;

            firstVar = 10;
            thirdVar = "Szkoła Dotneta";
            secondVar = 12.5f;
        }

        public void Ex5()
        {
            Console.WriteLine("Poproszę Cię o podanie wymieniony danych personalnych.");
            Console.Write("Imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Płeć (wpisz albo 'm' albo 'k'): ");
            char sex = char.Parse(Console.ReadLine());

            Console.Write("Adres: ");
            string address = Console.ReadLine();

            Console.Write("Numer telefonu: ");
            int phoneNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Adres Email: ");
            string email = Console.ReadLine();

            Console.Write("Wzrost (w cm): ");
            int height = Int32.Parse(Console.ReadLine());

            Console.Write("Waga: ");
            float weight = float.Parse(Console.ReadLine());
        }
    }
}
