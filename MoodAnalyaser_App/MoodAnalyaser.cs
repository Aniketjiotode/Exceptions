using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyaser_App
{
    public class MoodAnalyaser
    {
        private string message;

        public MoodAnalyaser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }            
        }

    }
}
