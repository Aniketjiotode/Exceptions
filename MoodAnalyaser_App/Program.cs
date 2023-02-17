using System;

namespace MoodAnalyaser_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyaser analyse = new MoodAnalyaser(null);
            Console.WriteLine( analyse.AnalyseMood());
        }
    }
}
