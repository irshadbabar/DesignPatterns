// See https://aka.ms/new-console-template for more information
using StatePattern;

Device device = new Android();
device.TurnOn();
device.TurnOff();


device = new Macbook();

device.TurnOn();
device.TurnOff();

Mobile mobile = new IPhone();
mobile.TurnOn();
mobile.GetNotificaitons();
mobile.TurnOff();