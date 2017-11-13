using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<string> text = new List<string>();
            string code = "";

            for (int i = 0; i < list.Count; i++)
            {
                code = "";
                code += (char)LeftConvertToCode(list[i]);
                if (code == "\0")
                {
                    continue;
                }
                else
                {
                    text.Insert(i, code);
                }

                code = "";
                code += (char)RightConvertToCode(list[i]);
                if (code == "\0")
                {
                    continue;
                }
                else
                {
                    text.Insert(text.Count - i, code);
                }
            }

            Console.WriteLine(string.Join("", text));
        }

        static int LeftConvertToCode(string num)
        {
            int index = num.IndexOf(".");
            num = num.Substring(0, index);
            int code = int.Parse(num);
            return code;
        }

        static int RightConvertToCode(string num)
        {
            int index = num.IndexOf(".");
            num = num.Substring(index + 1);
            int code = int.Parse(num);
            return code;
        }
    }
}
