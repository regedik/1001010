using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _1001010
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileInputName = "INPUT.txt";
            const string fileOutputName = "OUTPUT.txt";
            string str;

            StreamReader streamReader = null;
            StreamWriter write_text = null;

            FileInfo file = new FileInfo(fileInputName);

            if (!file.Exists)
            {
                Console.Write("No file!");
                Console.ReadKey(true);

                return;
            }

            try
            {
                streamReader = new StreamReader(fileInputName);

                str = streamReader.ReadLine();

                write_text = new StreamWriter(fileOutputName);
                write_text.Write(Funk(str));
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                streamReader.Close();
                write_text.Close();
            }
        }

        public static int Funk(string s)
        {
            int counter = 0;
            int maxLen = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    counter++;
                }
                else
                {
                    if (counter > maxLen)
                    {
                        maxLen = counter;
                    }

                    counter = 0;
                }
            }

            return (maxLen > counter) ? maxLen : counter;
        }
    }
}