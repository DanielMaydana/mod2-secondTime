using ConsoleUserInterface;

namespace AmazonRateCalculator
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Windows myWindow = new Windows();
            //myWindow.Renderize();
            myWindow.ReadConfiguration();
        }
    }
}
