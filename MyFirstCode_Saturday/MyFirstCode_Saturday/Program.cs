using System;

namespace MyFirstCode_Saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese el año.");
                int vyear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el mes.");
                int vmonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el día.");
                int vday = Convert.ToInt32(Console.ReadLine());
                var objDate = new Date(vyear, vmonth, vday);
                Console.WriteLine(objDate.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
         
        }
    }
}
