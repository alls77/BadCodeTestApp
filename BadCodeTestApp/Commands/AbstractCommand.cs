using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BadCodeTestApp.Commands
{
    abstract class AbstractCommand : ICommand
    {
        public void execute(string path)
        {
            try
            {
                Console.WriteLine("Start command");
                Console.WriteLine($"Params: {path}");
                Validate(path);
                AbstractExecute(path);
                Console.WriteLine("Command was executed");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }

        protected abstract void AbstractExecute(string path);

        protected virtual void Validate(string path)
        {
            if (String.IsNullOrWhiteSpace(path))
                throw new Exception("Incorrect path");
            if (!Directory.Exists(path))
                throw new Exception("Directory not found");
        }
    }
}