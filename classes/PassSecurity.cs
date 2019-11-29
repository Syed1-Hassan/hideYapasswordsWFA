using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace hideYApasswordsWFA.classes
{
    class PassSecurity
    {
        encryptionKey _getEncryptionKeyObj = new encryptionKey();
        private Dictionary<char, char> Key = new Dictionary<char, char>();
        public void savePasscode(string passcode, string dir)
        {
            encrypt code = new encrypt();
            string encPasscode = code.funcEncrypt(passcode);
            code.saveEncrypt("Passcode", encPasscode, dir);
        }
        public string decryptPasscode(string passcode)
        {
            string decPasscode = "";
            decrypt code = new decrypt();
            return decPasscode = code.funcDecrypt(passcode);
        }

        //public bool passcodeINfile(string dir)
        //{
        //    StreamReader reader = new StreamReader(dir);
        //    Regex reg = new Regex(@"^passcode \: \w {3}$");
        //    string line = reader.ReadLine();
        //    Match passcodeMatch = reg.Match(line);
        //    return (passcodeMatch.Success);

        //}
      
        public string fetchPasscodeFromDirectory(string dir)
        {
            string passCode = "";
            StreamReader reader = new StreamReader(dir);
            string line = reader.ReadLine();
            foreach (var s in Regex.Split(line, @"Passcode :  "))
            {
                passCode = passCode + s;
            }
            reader.Close();
            return passCode;

        }

        public string fetchPasswordFromDirectory(string dir, string email)
        {
            string passWord = "";
            StreamReader reader = new StreamReader(dir);
            Regex reg = new Regex(email + @".+$");
            string line = reader.ReadToEnd();
            string text = line.ToString();
            Match emailMatch = reg.Match(text);
          
            if (emailMatch.Success)
            {
                string Fetchemail = emailMatch.ToString();
                foreach (var s in Regex.Split(Fetchemail, @"^.+\@\w+\.com :  "))
                {
                    passWord = passWord + s;
                }

            }
            else
                passWord = "No match for email";
            reader.Close();
            return passWord;

        }
    }
}
