using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BadCodeTestApp.Commands.FileCommands
{
    class SearchByExt : Search
    {
        protected override void AbstractExecute(string path)
        {         
            search(path, GetExtension()).ToList<string>().ForEach(n => Console.WriteLine(n));
        }

        private string GetExtension()
        {
            Console.Write("Extension: ");
            return Console.ReadLine();
        }
    }
}