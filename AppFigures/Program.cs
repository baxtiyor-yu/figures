namespace AppFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.DisplayMessage("figures");
            Thread.Sleep(2000);
            new Intro().ShowMenu();
        }
    }
}
