using System;

namespace Composition.Example
{
    /*
     * The close we have in C$ to the package-private modifier of Java
     *   is the "internal" modifier, but it only protects the class from the
     *   use in another project in the solution (another DLL), not from
     *   inside the same project
     */
    internal class Window
    {
        private bool open;

        internal Window(bool initialState)
        {
            this.open = initialState;
        }

        internal void openWindow()
        {
            this.open = true;
            Console.WriteLine("Window: A window was opened");
        }

        internal void closeWindow()
        {
            this.open = false;
            Console.WriteLine("Window: A window was closed");
        }

        internal bool getState()
        {
            return this.open;
        }
    }
}
