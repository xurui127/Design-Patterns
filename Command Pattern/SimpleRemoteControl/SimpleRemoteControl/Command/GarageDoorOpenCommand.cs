using SimpleRemoteControl.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRemoteControl.Command
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor door;

        public GarageDoorOpenCommand(GarageDoor _door)
        {
            door = _door;
        }
        public void Excute()
        {
            door.Up();
        }
    }
}
