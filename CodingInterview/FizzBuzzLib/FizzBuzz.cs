using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        private Dictionary<int, string> testParm;
        private int _maxUpperBound;
        public FizzBuzz(int maxUpperBound)
        {
            testParm = new Dictionary<int, string>();
            _maxUpperBound = maxUpperBound;
        }

        public void AddTestParm(int number, string messgae)
        {
            testParm.Add(number, messgae);
        }

        public string GetOutputResponse(int number)
        {
            string response = string.Empty;
            foreach (var item in testParm)
            {
                if (number % item.Key == 0)
                {
                    response += item.Value;
                }
            }

            return response.Length > 0 ? response : number.ToString();
        }

        public string GenerateFizzBuzzResult()
        {
            string fileName = string.Empty;
            do
            {
                fileName = Path.GetRandomFileName();
            } while (File.Exists(fileName));

            using (TextWriter dest = File.CreateText(fileName))
            {
                for (int i = 1; i <= _maxUpperBound; i++)
                {
                    dest.WriteLine(GetOutputResponse(i));
                }
            }
            string readText = File.ReadAllText(fileName);
            File.Delete(fileName);

            return readText;
        }
    }
}
