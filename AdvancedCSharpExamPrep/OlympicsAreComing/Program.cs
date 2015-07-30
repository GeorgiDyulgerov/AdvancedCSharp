    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

class Program
    {
        static void Main()
        {
            string report = Console.ReadLine();
            var winers =new Dictionary<string,List<string>>();


            while (report!="report")
            {
                string[] info = report.Split('|').ToArray();
                string athlete =Regex.Replace(info[0].Trim(),@"\s{2,}", " ") ;
                string country = Regex.Replace(info[1].Trim(), @"\s{2,}", " ");
                if (!winers.ContainsKey(country))
                {
                   winers.Add(country,new List<string>());
                }
                winers[country].Add(athlete);

                report = Console.ReadLine();
            }
            var ordered = winers.OrderByDescending(x => x.Value.Count);
            foreach (var keyValuePair in ordered)
            {
                Console.WriteLine("{0} ({1} participants): {2} wins",keyValuePair.Key,keyValuePair.Value.Distinct().Count(),keyValuePair.Value.Count);
            }

        }
    }
