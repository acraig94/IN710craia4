using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class StringReverseParser : IcodeMachine
    {

        public StringReverseParser()
        {

        }

        public string decrypt(string input)
        {
            Char[] worker = input.ToCharArray();
            Array.Reverse(worker);
            string output = new string(worker);
            return output;
        }

        public string encrypt(string input)
        {
            Char[] worker = input.ToCharArray();
            Array.Reverse(worker);
            string output = new string(worker);
            return output;
        }
    }
}
