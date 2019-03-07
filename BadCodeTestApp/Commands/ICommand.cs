using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp.Commands
{
    interface ICommand
    {
        void execute(string path);
    }
}
