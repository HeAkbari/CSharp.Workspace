using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPSample
{
    public class Logger
    {
        const string path = @"D:\Log.txt";

        public static void WriteToFile(string methodName)
        {
            object lockObject = new object();
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            lock (lockObject)
            {
                using (TextWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(string.Format("{0} at {1}", methodName, DateTime.Now));
                }
            }
        }
    }
}
