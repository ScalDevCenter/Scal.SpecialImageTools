using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scal.MugenCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
//            var timings = new[] { 0, 300, 390, 1410, 1500, 2040, 2130, 2550, 2640, 3060, 3150, 3630, 3720, 3900, 3990, 4950, 5040, 5640, 5730, 6090, 6180, 7020, 7110, 7770, 7860, 7980, 8070, 8430, 8520, 8820, 8910, 9750, 9840, 10260, 10350, 10530, 10620, 11580, 11670, 12090, 12180, 12720, 12810 };
//            var prefixes = new[] { "SetIdleAnim", "SetWaterAnim" };
//            var values = new[] { 50, 51 };

            var timings = new[] { 0, 616, 682, 1606, 1672, 2904, 2970, 4378, 4444 };
            var prefixes = new[] { "SetIdleAnim", "SetMouthOpenAnim" };
            var values = new[] { 90, 91 };


            var sb = new StringBuilder();
            var loopId = 1;

            for(var i = 0; i < timings.Length / 2; i++)
            {
                SetAnimBgCtrl(sb,
                    string.Format("{0}{1}", prefixes[0], loopId.ToString().PadLeft(2, '0')),
                    timings[i * 2],
                    values[0]);

                SetAnimBgCtrl(sb,
                    string.Format("{0}{1}", prefixes[1], loopId.ToString().PadLeft(2, '0')),
                    timings[(i * 2) + 1],
                    values[1]);

                loopId++;
            }

            if(timings.Length > 0 && timings.Length % 2 > 0)
            {
                SetAnimBgCtrl(sb,
                    string.Format("{0}{1}", prefixes[0], loopId.ToString().PadLeft(2, '0')),
                    timings.Last(),
                    50);

            }

            File.WriteAllText("MugenCode.txt", sb.ToString());
        }

        private static void SetAnimBgCtrl(StringBuilder sb, string title, int time, int value)
        {
            if (sb == null) sb = new StringBuilder();

            sb.AppendFormat("[BGCtrl {0}]\r\n", title);
            sb.Append("type = Anim\r\n");
            sb.AppendFormat("time = {0}\r\n", time);
            sb.AppendFormat("value = {0}\r\n\r\n", value);
        }
    }
}
