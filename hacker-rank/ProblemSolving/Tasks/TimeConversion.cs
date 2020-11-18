using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Tasks
{
    public static class TimeConversion
    {
        static string timeConversion(string s)
        {
            string[] Time = s.Split(':');
            var amPM = "";
            string convertedTime = "";

            foreach (char c in Time[2])
            {
                if (c == 'P' || c == 'A' || c == 'M')
                {
                    amPM += c;
                }
            }

            switch (amPM)
            {
                case "AM":
                    var tAm = int.Parse(Time[0]);
                    if (tAm == 12) { convertedTime += "00" + ":" + Time[1] + ":" + Time[2].Trim('A', 'M'); }
                    else { convertedTime = s.Trim('A', 'M'); }
                    break;

                case "PM":
                    var t = (int.Parse(Time[0]) == 12) ? int.Parse(Time[0]) : int.Parse(Time[0]) + 12;
                    convertedTime = t.ToString();
                    if (convertedTime == "24") { convertedTime = "00:00:00"; }
                    else { convertedTime += ":" + Time[1] + ":" + Time[2].Trim('P', 'M'); }
                    break;
            }

            return convertedTime;
        }
    }
}
