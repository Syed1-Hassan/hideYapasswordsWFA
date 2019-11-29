using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hideYApasswordsWFA.classes
{

    class encryptionKey
    {

       public Dictionary<char,char> dictionary()
        {

            Dictionary<char, char> enkey = new Dictionary<char, char>();

            enkey.Add('q', 'Z');
            enkey.Add('w', 'X');
            enkey.Add('e', 'C');
            enkey.Add('r', 'V');
            enkey.Add('t', 'B');
            enkey.Add('y', 'N');

            enkey.Add('u', '6');

            enkey.Add('i', 'Q');
            enkey.Add('o', 'W');
            enkey.Add('p', '9');
            enkey.Add('a', 'E');
            enkey.Add('s', 'R');
            enkey.Add('d', 'T');
            enkey.Add('f', 'Y');
            enkey.Add('g', 'U');
            enkey.Add('h', 'I');
            enkey.Add('j', 'O');
            enkey.Add('k', 'P');

            enkey.Add('l', '@');
            enkey.Add('z', '-');
            enkey.Add('x', '_');

            enkey.Add('c', '7');
            enkey.Add('v', '2');
            enkey.Add('b', '3');
            enkey.Add('n', '4');
            enkey.Add('m', '5');

            enkey.Add('Q', 'a');
            enkey.Add('W', 's');
            enkey.Add('E', 'd');
            enkey.Add('R', 'f');
            enkey.Add('T', 'g');
            enkey.Add('Y', 'h');
            enkey.Add('U', 'j');
            enkey.Add('I', 'k');
            enkey.Add('O', 'l');
            enkey.Add('P', 'z');
            enkey.Add('A', 'x');
            enkey.Add('S', 'c');
            enkey.Add('D', 'v');
            enkey.Add('F', 'b');
            enkey.Add('G', 'n');
            enkey.Add('H', 'm');
            enkey.Add('J', 'q');
            enkey.Add('K', 'w');
            enkey.Add('L', 'e');
            enkey.Add('Z', 'r');
            enkey.Add('X', 't');
            enkey.Add('C', 'y');
            enkey.Add('V', 'u');
            enkey.Add('B', 'i');
            enkey.Add('N', 'o');
            enkey.Add('M', 'p');
            
            enkey.Add('1', 'L');
            enkey.Add('2', 'K');
            enkey.Add('3', 'J');
            enkey.Add('4', 'H');
            enkey.Add('5', 'G');
            enkey.Add('6', 'F');
            enkey.Add('7', 'D');
            enkey.Add('8', 'S');
            enkey.Add('9', 'A');
            enkey.Add('0', '1');

            enkey.Add('-', '.');
            enkey.Add('@', '&');
            enkey.Add('_', '8');
            enkey.Add('.', 'M');
            enkey.Add(' ', ' ');
            enkey.Add(':', ':');
            
            return enkey;
        }
            
    }
}
