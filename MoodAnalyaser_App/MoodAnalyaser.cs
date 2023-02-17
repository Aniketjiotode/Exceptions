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
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.Empty_Message, "Empty Mood message not valid");

                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }            
            }
            catch(NullReferenceException) 
            {
                throw new CustomException(CustomException.ExceptionType.Null_Message, "Null message not valid");

            }
        }

    }
}
