using System;
using Composition.Example;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            StudioHouse home = new StudioHouse();
            home.openBedroomWindow();
            home.logAllWindowsStates();
            home.closeAllWindows();
            home.logAllWindowsStates();
        }
    }
}
