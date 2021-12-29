using System;

namespace Composition.Example
{
    public class StudioHouse
    {
        private Window bedroomWindow;
        private Window kitchenWindow;

        public StudioHouse()
        {
            this.bedroomWindow = new Window(false);
            this.kitchenWindow = new Window(false);
        }

        public void openBedroomWindow()
        {
            this.bedroomWindow.openWindow();
        }

        public void openKitchenWindow()
        {
            this.kitchenWindow.openWindow();
        }

        public void openAllWindows()
        {
            this.bedroomWindow.openWindow();
            this.kitchenWindow.openWindow();
        }

        public void closeBedroomWindow()
        {
            this.bedroomWindow.closeWindow();
        }

        public void closeKitchenWindow()
        {
            this.kitchenWindow.closeWindow();
        }

        public void closeAllWindows()
        {
            this.bedroomWindow.closeWindow();
            this.kitchenWindow.closeWindow();
        }

        public void logAllWindowsStates()
        {
            Console.WriteLine("StudioHouse: The bedroom window is " + this.bedroomWindow.getState());
            Console.WriteLine("StudioHouse: The kitchen window is " + this.kitchenWindow.getState());
        }
    }
}
