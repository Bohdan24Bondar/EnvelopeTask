using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeTask
{
    class Viewer
    {
        #region Consts

        public const int DIVIDER = 2;
        public char SEPARATOR = ',';
        public int COUNT_OF_SEPARATE = 2;

        #endregion

        #region Private

        private string _instruction;

        #endregion

        public Viewer(string startMessage, string instruction)
        {
            _instruction = instruction;
        }

        public string[] InputParameters() //TODO
        {
            bool isRightParameters;
            string parameters = string.Empty;

            do
            {
                SetCursorPosition(_instruction);
                parameters = Console.ReadLine();
                isRightParameters = IsRightParameters(parameters);

            } while (!isRightParameters);

            return parameters.Split(new char[] { SEPARATOR });
        }

        private bool IsRightParameters(string parameters)
        {
            string[] triangleArgs = parameters.Split(new char[] { SEPARATOR });

            if (triangleArgs.Length != COUNT_OF_SEPARATE) 
            {
                return false;
            }

            return true;
        }

        public string InputAnswer(string message)//todo out
        {
            SetCursorPosition(message);

            return Console.ReadLine();
        }

        public void ShowMessage(string message)
        {
            SetCursorPosition(message);
            Console.ReadKey();
        }

        private void SetCursorPosition(string message)
        {
            string[] lines = message.Split(new char[] { '\n' });

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            int middleHeight = (Console.WindowHeight - lines.Length) / DIVIDER;
            int middleWidth = (Console.WindowWidth - lines[0].Length) / DIVIDER;

            for (int i = 0; i < lines.Length; i++)
            {
                Console.SetCursorPosition(middleWidth, middleHeight++);
                Console.Write(lines[i]);
            }

            Console.SetCursorPosition(middleWidth, middleHeight++);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
