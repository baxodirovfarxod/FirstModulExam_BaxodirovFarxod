namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var texts = new List<string>() {"farxod", "robiya" , "dsjd" };
            Console.WriteLine(AllLongerThree(texts));
        }

        // 1 savol
        public static string GetLastFourElement(string text)
        {
            if (text.Length >= 4)
            {
                return text.Substring(text.Length - 4);
            }

            return text;
        }
        // 2 savol
        
        public static int OddElements(List<int> numbers)
        {
            var counter = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    counter++;
                }
            }

            return counter;
        }
        // 3 savol 
        public static bool EndWith(string text)
        {
            return text.EndsWith("g_10");
        }
        // 4 savol
        public static bool AllLongerThree(List<string> texts)
        {
            foreach (var text in texts)
            {
                if (text.Length < 4)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
