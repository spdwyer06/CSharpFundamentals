using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_ConsoleUI.UI
{
    class RealConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey() // => Console.ReadKey();
        {
           return Console.ReadKey();
        }

        public string ReadLine() // => Console.ReadLine();
        {
          return Console.ReadLine();
        }

        public void Write(string str) // Parameter
        {
            Console.Write(str);  // Parameter
        }

        public void WriteLine(string str)  //
        {
            Console.WriteLine(str);  //
        }

        public void WriteLine(object obj)  //
        {
            Console.WriteLine(obj);  //
        }
    }
}
