using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NumbericConvertorLibrary;
using EnvelopeTaskLibrary;
using ContinueCheckerLibrary;

namespace EnvelopeTask
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				ConsoleController application = new ConsoleController(DefaultSettings.INSTRUCTION);//todo
				application.Run();
			}
			catch (Exception)
			{
				Console.WriteLine(DefaultSettings.INSTRUCTION);
				Console.ReadKey();
			}

			Console.Clear();
			Console.ReadKey();
        }
    }
}
