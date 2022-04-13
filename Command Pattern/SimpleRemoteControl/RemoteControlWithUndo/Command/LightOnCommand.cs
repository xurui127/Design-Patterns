using RemoteControlWithUndo.Command.Abstractions;
using RemoteControlWithUndo.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControlWithUndo.Command
{
    public class LightOnCommand:ICommand
    {
        Light light;

        public LightOnCommand(Light _light)
        {
            light = _light;
        }

         public void Excute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}
