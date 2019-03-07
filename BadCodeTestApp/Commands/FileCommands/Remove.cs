using BadCodeTestApp.Commands;
using BadCodeTestApp.Commands.FileCommands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Remove : AbstractCommand
    {
        protected override void AbstractExecute(string path)
        {
            remove(path);
        }

        protected void remove(string path)
        {
            File.Delete(path + "\\test.txt");
        }
    }
}