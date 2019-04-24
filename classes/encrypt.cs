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
        encryptionKey _getEncryptionKeyObj = new encryptionKey();
       private Dictionary<char, char> Key = new Dictionary<char, char>();
       
        public string funcEncrypt(string s)
        {
            Key=_getEncryptionKeyObj.dictionary();
            string retEncrypt = "";
            for (int i = 0; i < s.Length; i++)
            {

                if (Key.ContainsKey(s[i]))
                {
                    retEncrypt = retEncrypt + Key[s[i]];
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
