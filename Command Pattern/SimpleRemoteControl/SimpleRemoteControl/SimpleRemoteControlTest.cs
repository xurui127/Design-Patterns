using SimpleRemoteControl.Command;
using SimpleRemoteControl.Invoke;
using SimpleRemoteControl.Receiver;
using System;

namespace SimpleRemoteControl
{
    class SimpleRemoteControlTest
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light();

            LightOnCommand lightOnCommand = new LightOnCommand(light);
            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();


            GarageDoor door = new GarageDoor();

            GarageDoorOpenCommand openCommand = new GarageDoorOpenCommand(door);
            remote.SetCommand(openCommand);
            remote.ButtonWasPressed();

        }
    }
}
