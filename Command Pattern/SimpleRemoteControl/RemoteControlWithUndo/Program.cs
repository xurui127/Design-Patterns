using RemoteControlWithUndo.Command;
using RemoteControlWithUndo.Invoke;
using RemoteControlWithUndo.Receiver;
using System;

namespace RemoteControlWithUndo
{
    class Program
    {
        static void Main(string[] args)
        {

            RemoteControl remote = new RemoteControl();
            #region // Light 
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");

          
            


            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            Console.WriteLine(remote);


            remote.UndoButtonWasPushed();
            remote.OffButtonWasPushed(0);

            remote.OnButtonWasPushed(0);
            Console.WriteLine(remote);
            #endregion

            CeilingFan ceilingFan = new CeilingFan("Living Room");
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(2, ceilingFanMedium, ceilingFanOffCommand);
            remote.SetCommand(3, ceilingFanHigh, ceilingFanOffCommand);

            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            Console.WriteLine(remote) ;
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(3);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();
        }
    }
}
