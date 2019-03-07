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
    class Create : AbstractCommand
    {
        protected override void AbstractExecute(string path)
        {
            create(path);
        }

        protected void create(string path)
        {
            File.Create(path + "\\test.txt");
        }
    }
}