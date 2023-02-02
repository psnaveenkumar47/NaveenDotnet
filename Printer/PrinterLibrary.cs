public delegate void PrintDelegate();
namespace DelegateAssignment
{
    public class PrinterLibrary
    {
        public static void Print(PrintDelegate P)
        {
            P();
        }
    }
}