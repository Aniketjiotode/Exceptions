using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyaser_App
{
    public class CustomException:Exception
    {
        public enum ExceptionType
        {
            Null_Message,
            Empty_Message
        }

      private  ExceptionType Type;

        public CustomException(ExceptionType type,string message) :base(message)
        { 
            Type = type;    
        }

    }

}
