using Console_Organisations.DataSource;

namespace Console_Organisations
{
    internal class Program
    {
        static List<Organization> organizations100 = new List<Organization>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(".\\DataSource\\organizations-100.csv");

            sr.ReadLine();
            
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(",");

                Organization dataRow = new Organization(
                    int.Parse(line[0]),
                    line[1],
                    line[2],
                    line[3],
                    line[4],
                    line[5],
                    int.Parse(line[6]),
                    line[7],
                    int.Parse(line[8])
                    );

                organizations100.Add( dataRow );   
            }

            sr.Close();

            StreamReader sr1 = new StreamReader(".\\DataSource\\organizations-100000");

            sr1.ReadLine();

            while (!sr1.EndOfStream)
            {
                string[] line1 = sr.ReadLine().Split(",");

                Organization datarow2 = new Organization(
                    int.Parse(line1[0]),
                    line1[1],
                    line1[2],
                    line1[3],
                    line1[4],
                    line1[5],
                    int.Parse(line1[6]),
                    line1[7],
                    int.Parse(line1[8])
                    );
            }

            sr1.Close();

            List<Organization> foundedIn2021 =  organizations100.Where(x => x.Founded == 2012).ToList();

            foundedIn2021.ForEach(x => Console.WriteLine(x.Name));

        }
    }
}