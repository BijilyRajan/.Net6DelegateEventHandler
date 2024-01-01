using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventHandler
{
    //This class is used to provice additional information related to the button click event to
    //the subscribers.
    public class ButtonClickEventArgs:EventArgs
    {
        public string ButtonName;

        public ButtonClickEventArgs(string buttonName)
        {
            ButtonName = buttonName;
        }
    }
}
