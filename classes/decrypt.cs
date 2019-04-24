using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hideYApasswordsWFA.classes
{
    class decrypt
    {
        encryptionKey _getEncryptionKeyObj = new encryptionKey();
        private Dictionary<char, char> Key = new Dictionary<char, char>();
        public string funcDecrypt(string s)
        {
            Key = _getEncryptionKeyObj.dictionary();
            string retDecrypt = "";
            for (int i = 0; i < s.Length; i++)
            {

                if (Key.ContainsKey(s[i]))
                {

                    char result = Key.Keys.FirstOrDefault(t => Key[t] == s[i]);
                    retDecrypt = retDecrypt + result;

                }

            }

            return retDecrypt;
        }
    }
}
