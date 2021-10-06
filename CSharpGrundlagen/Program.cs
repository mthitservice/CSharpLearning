namespace MeinProgramm
{
    #region "Meine erste Klasse"
    class Program
    {
        static void Main(string[] param)
        {
#if DEBUG
            System.Console.WriteLine("Hello World! Debug");
#else
        System.Console.WriteLine("Hello World! Release");
#endif
        }
    }

#endregion
}
