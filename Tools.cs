using System;
using System.IO;

namespace True_or_False_Game
{
  public class Tools
  {
    public static void SetUpInputStream(string sample)
    {
			if (sample == null)
			{
				Console.SetIn(new StreamReader("true.txt"));
			}      
    }
  }
}
