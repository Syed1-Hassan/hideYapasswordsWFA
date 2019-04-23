using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace hideYApasswordsWFA.classes
{
    class encrypt
    {
        public string funcEncrypt(string s, Dictionary<char, char> x)
        {
            string retEncrypt = "";
            for (int i = 0; i < s.Length; i++)
            {

                if (x.ContainsKey(s[i]))
                {
                    retEncrypt = retEncrypt + x[s[i]];
                }

            }
            return retEncrypt;
        }

        public void saveEncrypt(string email, string code, string filepath)
        {
            //SetAccessRule(filepath);
            StreamWriter h = new StreamWriter(filepath, true);
            h.WriteLine(email + " :  " + code);
            h.Close();

        }
    }
}
