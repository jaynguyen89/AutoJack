using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace AutoJack.common {

    class Utility {
        public static string GetBasePath() {
            string CurrentPath = Directory.GetCurrentDirectory();

            string[] tokens = CurrentPath.Split('\\');
            string AppFolder = String.Empty;
            for (int i = 0; i < tokens.Length - 2; i++)
                AppFolder += tokens[i] + @"\";

            return AppFolder;
        }

        public static double RandDoubleInRange(double lower, double upper) {
            Random rand = new Random();
            double randValue = rand.NextDouble() * (upper - lower) + lower;

            return randValue;
        }

        public static double Max(double[] values) {
            double max = values[0];

            for (int i = 1; i < values.Length; i++)
                if (values[i] > max)
                    max = values[i];

            return max;
        }
    }
}
