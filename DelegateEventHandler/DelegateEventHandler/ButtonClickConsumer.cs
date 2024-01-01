using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventHandler
{
    public class ButtonClickConsumer
    {
        public void HandleButtonClick(object sender, ButtonClickEventArgs e)
        {
            Console.WriteLine($"Clicked by button { e.ButtonName }");
        }
    }
}
