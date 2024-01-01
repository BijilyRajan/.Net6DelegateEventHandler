using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventHandler
{
    public class Button
    {

        //Define a delegate for the button click event
        public delegate void ClickEventHandler(object sender, ButtonClickEventArgs e);

        //Declare an event using the delegate
        public event ClickEventHandler Click;

        public void SimulateButtonClick()
        {
            Console.WriteLine("Button Clicked");
            //Click Event will invoke here!
            Click?.Invoke(this, new ButtonClickEventArgs("MyButton"));
        }

    }
}
