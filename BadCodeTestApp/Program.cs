using BadCodeTestApp.Commands;
using BadCodeTestApp.Commands.FileCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadCodeTestApp
{
    class Program
    {
        static Dictionary<string, ICommand> supportedCommands = new Dictionary<string, ICommand>();

        static Program()
        {
            register();
        }

        static void register()
        {
            supportedCommands.Add("search", new Search());
            supportedCommands.Add("search_by_ext", new SearchByExt());
            supportedCommands.Add("create_txt", new Create());
            supportedCommands.Add("remove_txt", new Remove());
        }

        static void Main(string[] args)
        {
            try
            {
                string command = args[0];
                string param = args[1];
                supportedCommands[command].execute(param);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Enter command and path");
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine("Command doesn't exist");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}