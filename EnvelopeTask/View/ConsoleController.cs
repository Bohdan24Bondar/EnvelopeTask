using ContinueCheckerLibrary;
using EnvelopeTaskLibrary;
using NumbericConvertorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeTask
{
    class ConsoleController
    {
        public ConsoleController(string instruction)
        {
            Instruction = instruction;
        }

        public string Instruction { get; private set; }

        public void Run()
        {
            Viewer consoleViewer = new Viewer(DefaultSettings.QUESTION, Instruction);

            try
            {
                bool canContinue = false;

                do
                {
                    string[] args = consoleViewer.InputParameters();
                    NumbericConvertor parametersConvertor = new NumbericConvertor(args);
                    double[] sides = new double[DefaultSettings.SIDES_COUNT];
                    parametersConvertor.GetNumbers(out sides);
                    Envelope bigEnvelope = new Envelope(sides[0], sides[1]);

                    args = consoleViewer.InputParameters();
                    parametersConvertor = new NumbericConvertor(args);
                    sides = new double[DefaultSettings.SIDES_COUNT];
                    parametersConvertor.GetNumbers(out sides);
                    Envelope smallEnvelope = new Envelope(sides[0], sides[1]);

                    EnvelopesAnalyzer analyzer = new EnvelopesAnalyzer();
                    bool result = analyzer.CanPutInEnvelope(bigEnvelope, smallEnvelope);

                    if (result)
                    {
                        consoleViewer.ShowMessage(string.Format("{0}\n{1}",
                            DefaultSettings.RIGHT_ENVELOPE, DefaultSettings.MESSAGE));
                    }

                    string userAnswer = consoleViewer.InputAnswer(DefaultSettings.QUESTION);
                    ContinueChecker answerChecker = new ContinueChecker(new string[] { "y", "yes" });
                    canContinue = answerChecker.CanContinue(userAnswer);

                } while (canContinue);
                
            }
            catch (FormatException ex)
            {
                consoleViewer.ShowMessage(string.Format("{0}\n{1}", ex.Message, Instruction));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                consoleViewer.ShowMessage(string.Format("{0}\n{1}", ex.Message, Instruction));
            }
        }
    }
}
