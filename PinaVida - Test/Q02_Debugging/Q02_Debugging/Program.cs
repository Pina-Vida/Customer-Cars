namespace Q02_Debugging
{
    class Program
    {
        static Speed s;

        static void Main(string[] args)
        {
            Console.Write("KM: ");
            string hours = Console.ReadLine();
            Console.Write("Hours: ");
            string km = Console.ReadLine();

            double.TryParse(km, out s.km);
            double.TryParse(hours, out s.hours);

            Console.WriteLine("KPH: " + s.kph);
            Console.ReadKey();
        }
    }

    class Speed
    {
        public double km = 0;
        public double hours = 0;

        public int kph
        {
            get
            {
                return km / hours;
            }
        }
    }
}