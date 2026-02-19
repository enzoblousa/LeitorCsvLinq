using Course.Entities;
using System.Globalization;
using System.Linq;


namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {

            List<Employee> lista = new List<Employee>();

            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path)) 
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');

                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    lista.Add(new(name, email, salary));
                }

            }
            Console.Write("Enter salary: ");
            double salaryparam = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var r1 = lista.Where(e => e.Salary > salaryparam).OrderBy(e => e.Email).Select(e => e.Email);

            
            Console.WriteLine("Emails for those salary is more than " + salaryparam );

            foreach (var e in r1) 
            {
                Console.WriteLine(e);
            }

            var r2 = lista.Where(e => e.Name.StartsWith('M')).Sum(e => e.Salary);

            Console.WriteLine(r2);
        }
    }
}
