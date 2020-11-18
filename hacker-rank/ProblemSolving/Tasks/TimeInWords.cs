using System.Collections.Generic;

namespace practice.Tasks
{
    public static class TimeinWords
    {
       public  static string timeInWords(int h, int m)
         {
             var values = new Dictionary<int ,string>()
             {
                 {1,"one"},{2,"two"},{3,"three"},
                 {4,"four"},{5,"five"},{6,"six"},
                 {7,"seven"},{8,"eight"},{9,"nine"},
                 {10,"ten"},{11,"eleven"},{12,"twelve"},
                 {13,"thirteen"},{14,"fourteen"},{15,"fifteen"},
                 {16,"sixteen"},{17,"seventeen"},{18,"eighteen"},
                 {19,"nineteen"},{20,"twenty"},
                 
             };
            
             switch(m)
             {
                 case 0:
                 return $"{values[h]} o' clock";
                 
                 case 15:
                 return $"quarter past {values[h]}";

                 case 30:
                 return $"half past {values[h]}";

                 case 45:
                 return $"quarter to {values[h+1]}";

                 default:
                 {
                        string mins = m > 9 ? "minutes":"minute" ;
                        string beforeAfter = m > 30 ? $"to {values[h+1]}" : $"past {values[h]}";
                        string minutesString;

                        if (m > 30)
                        {
                            int minutes = 60 - m;
                            minutesString = minutes > 20 ? $"{values[20]} {values[minutes - 20]}" : $"{values[minutes]}";
                        }
                        else
                        {
                            minutesString = m > 20 ? $"{values[20]} {values[m - 20]}" : $"{values[m]}";
                        }

                        return $"{minutesString} {mins} {beforeAfter}";
                 }
             }
        }
    }
}