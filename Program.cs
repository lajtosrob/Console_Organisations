using Console_Organisations.DataSource;
using System.Linq;

namespace Console_Organisations
{
    internal class Program
    {
        static List<Organization> organizations100 = new List<Organization>();
        static List<Organization> organizations100000 = new List<Organization>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(".\\DataSource\\organizations-100.csv");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(",");

                if(line.Length == 9) 
                {
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

                    organizations100.Add(dataRow);                
                }


            }

            sr.Close();

            StreamReader sr1 = new StreamReader(".\\DataSource\\organizations-100000.csv");

            sr1.ReadLine();

            while (!sr1.EndOfStream)
            {
                string[] line1 = sr1.ReadLine().Split(",");

                if (line1.Length == 9)
                {
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

                    organizations100000.Add(datarow2);

                }

            }

            sr1.Close();

            // 1. feladat:  Hány szervezetet alapítottak 2012-ben?

            var foundedIn2012 = organizations100.Where(x => x.Founded == 2012).Count();
            var foundedIn2012V2 = organizations100000.Where(x => x.Founded == 2012).Count();

            Console.WriteLine($"1. feladat: 2021-ben alaptott szervezetek száma (100):  { foundedIn2012}");
            Console.WriteLine($"1. feladat: 2021-ben alaptott szervezetek száma (100000):  { foundedIn2012V2}");

            //. 2. feladat:  "Secondary Education" területen vagy "Military Industry" területen dolgoznak többen?

            var secondaryEducation = organizations100.Where(x => x.Industry == "Secondary Industry").Sum(x => x.NumberOfEmployees) ;
            var militaryIndustry = organizations100.Where(x => x.Industry == "Military Industry").Sum(x => x.NumberOfEmployees);

            if (secondaryEducation > militaryIndustry)
            {
                Console.WriteLine($"2. feladat: Secondary Education területen dolgoznak többen. (100) {secondaryEducation - militaryIndustry} fő");
            }
            else
            {
                Console.WriteLine($"2. feladat: Military Industry területen dolgoznak többen. (100) {militaryIndustry-secondaryEducation} fő");
            }

            var secondaryEducation2 = organizations100000.Where(x => x.Industry == "Secondary Education").Sum(x => x.NumberOfEmployees);
            var militaryIndustry2 = organizations100000.Where(x => x.Industry == "Military Industry").Sum(x => x.NumberOfEmployees );

            if (secondaryEducation2 > militaryIndustry2)
            {
                Console.WriteLine($"2. feladat: Secondary Education területen dolgoznak többen. (100000) {secondaryEducation2 - militaryIndustry2} fő");
            }
            else
            {
                Console.WriteLine($"2. feladat: Military Industry területen dolgoznak többen. (100000) {militaryIndustry2 - secondaryEducation2} fő");
            }

        }
    }
}