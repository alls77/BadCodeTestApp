using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCodeTestApp.Commands.FileCommands
{
    class Search :AbstractCommand
    {
        protected override void AbstractExecute(string path)
        {
            search(path).ForEach(n => Console.WriteLine(n));
        }

        protected List<string> search(string path, string ext = "*")
        {
            return Directory.GetFiles(path, ext, SearchOption.AllDirectories).ToList();
        }
    }
}