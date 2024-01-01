// See https://aka.ms/new-console-template for more information
using DelegateEventHandler;



//Initialize button class object
Button button = new Button();

//Initialize the consumer class and attach event delegate to the Click event.
ButtonClickConsumer consumer = new ButtonClickConsumer();
button.Click += consumer.HandleButtonClick;

button.SimulateButtonClick();

Console.ReadKey();


