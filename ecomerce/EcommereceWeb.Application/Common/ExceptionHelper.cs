namespace Sitex.Mvc.Helper
{
    public static class ExceptionHelper
    {
        public static void PrintExp(Exception ex, string name)
        {
            Console.WriteLine($" =.=.=.=.=.=.=.=.=.=.=.=.=.=.=.=.=.= EXP IN {name} =.=.=.=.=.=.=.=.=.=.=.=.=.=.=.=.=.= ");
            Console.WriteLine($"{ex.Message}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"-.-.-.-.-.-.-.-.-.-.-.-.-.- Inner -.-.-.-.-.-.-.-.-.-.-");
                Console.WriteLine($"{ex.InnerException.Message}");
            }
            Console.WriteLine($" =.=.=.=.=.=.=.=.=.=.=.=.=.=.=.=.=.= End of EXP Log =.=.=.=.=.=.=.=.=.=.=.=.=.=.=.=.=.= ");
        }
    }
}
