namespace GenericDictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Dictionary<int, int> rollFrequency = new Dictionary<int, int>();
            for (int rollCount = 0; rollCount < 10; rollCount++)
            {
                Random randomRoller = new Random();
                int roll = randomRoller.Next(1, 7);
                if (rollFrequency.ContainsKey(roll))
                    rollFrequency[roll]++;
                else
                    rollFrequency[roll] = 1;
            }
            foreach (var row in rollFrequency)
            {
                Console.WriteLine("KEY : {0}   VALUE : {1}", row.Key, row.Value);
            }
        }

        private static void CaseStudy1()
        {
            Dictionary<string, string> stateCodes = new Dictionary<string, string>();
            stateCodes.Add("MH", "Maharastra");
            stateCodes.Add("KA", "Karnatka");
            stateCodes.Add("KL", "Kerla");

            if (stateCodes.ContainsKey("KL"))
            {
                stateCodes.Remove("KL");
                stateCodes.Add("KL", "New Kerla");
            }

            Console.WriteLine(stateCodes.Count);

            foreach (var row in stateCodes)
            {
                Console.WriteLine("KEY : {0}   VALUE : {1}", row.Key, row.Value);
            }
            stateCodes["MH"] = "NEW Maharastra";
            Console.WriteLine();
            stateCodes["M"] = "NEW Maharastra";

            foreach (var row in stateCodes)
            {
                Console.WriteLine("KEY : {0}   VALUE : {1}", row.Key, row.Value);
            }
        }
    }
}