using System;

namespace MissileCommand
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (MissileCommand game = new MissileCommand())
            {
                game.Run();
            }
        }
    }
#endif
}

