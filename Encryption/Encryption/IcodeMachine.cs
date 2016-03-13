using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    interface IcodeMachine
    {
        string encrypt(string input);
        string decrypt(string input);
    }
}
