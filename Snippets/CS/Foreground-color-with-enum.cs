using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.codeproject.com/Questions/121424/Convert-String-to-System-ConsoleColor
namespace Colors
{
    public class Color
    {
       public Color(string color)
       {
          Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);
       }
    }
}
