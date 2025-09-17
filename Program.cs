namespace Assignment4._3._2
{
    public class Program
    {
        static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            GetInputList();
            ElementFrequencyCounter();
        }

        public static void GetInputList()
        {
            Console.Write($"Input the number of elements to be stored in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Input {n} elements in the array: ");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element - {i + 1}: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }

        public static void ElementFrequencyCounter()
        {
            var frequency = list.GroupBy(x => x)
                             .ToDictionary(x => x.Key, x => x.Count());

            foreach (var element in frequency)
            {
                Console.WriteLine($"{element.Key} appears {element.Value} times.");
            }
        }


        //Alternative Method
        /*
        public static void ElementFrequencyCounter()
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int x in list)
            {
                if (frequency.ContainsKey(x))
                {
                    frequency[x]++;
                }
                else
                {
                    frequency[x] = 1;
                }
            }

            foreach (var element in frequency)
            {
                Console.WriteLine($"{element.Key} appears {element.Value} times.");
            }
        }
        */
    }
}
