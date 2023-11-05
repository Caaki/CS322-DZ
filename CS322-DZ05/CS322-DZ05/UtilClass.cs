using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ05
{
    internal class UtilClass
    {

        private static int asciiCharacterStartLoverCase = 65; 
        private static int asciiCharacterEndLoverCase = 90;
        private static Random random = new Random(DateTime.Now.Millisecond);


        private static int asciiCharacterStartUpperCase = 97;
        private static int asciiCharacterEndUpperCase = 122;
        public static double square(int a, int b)
        {
            double result = 1;
            for (int i = 0; i < b; i++) {
                result = result * a;
            }
            return result;
        }

        public static String randomName()
        {
            String randomName = "";
            randomName += (char)(random.Next(asciiCharacterStartLoverCase, asciiCharacterEndLoverCase + 1) % 255);

            for (int i = 1; i <= 7;i++)
            {
                randomName += (char)(random.Next(asciiCharacterStartUpperCase, asciiCharacterEndUpperCase + 1) % 255);
            }
            return randomName;
        }

        public static int randomNumber()
        {
            return random.Next(1, 100 + 1) % 100;
        }

    }
}
