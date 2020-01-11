using System;

namespace SwitchExample_JS
{
    class Program
    {
        static void Main(string[] args)
        {
            var caseSwitch = 1;
            var result="";

            switch (caseSwitch)
            {
                case 1:
                    result = "Case 1";
                    break;
                case 2:
                    result = "Case 2";
                    break;
                case 3:
                    result = "Case 3";
                    break;
                default:
                    result = "Default Case";
                    break;
            }
            Console.WriteLine(result);


            //Now using c# 8 switch expression

            var caseSwitch2 = 2;
            var result2 = "";
            result2 = caseSwitch2 switch

            {
                1 => "Case 1",
                2 => "Case 2",
                3 => "Case 3 ",
                _ => "Default Case"
            };

            Console.WriteLine("Using c#8 Switch expression:\n"+ result2);

        }
    }
}
  