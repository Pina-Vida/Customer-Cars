
namespace Q04_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            PopulateData();
        }

        //This function must list all the character Names and their Age
        //Use the sample.xml file in this project to get the information
        //Final result must be 4 rows/lines
        // Example Row Format: Name (Age)
        private static void PopulateData()
        {
            //Load XML into string
            var xml = new StreamReader("sample.xml").ReadToEnd();

            //Display each row in the console app - add code here

            Console.ReadKey();
        }
    }
}