using _07_RepositoryPattern_ConsoleUI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Tests.UI
{
    class MockConsole : IConsole
    {
        private Queue<string> _userInput;

        public MockConsole(IEnumerable<string> input) 
        {
            _userInput = new Queue<string>(input); 
        }

        public string Output { get; set; } = ""; 

        public void Clear()
        {
            Output += "Called Clear Method\n";
        }

        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            string nextInput = _userInput.Dequeue();
            return nextInput; 
        }

        public void Write(string str) // Parameter
        {
            Output += str; // Parameter
        }

        public void WriteLine(string str) //
        {
            Output += str + "\n"; //
        }

        public void WriteLine(object obj) //
        {
            Output += obj + "\n"; //
        }
    }
}
