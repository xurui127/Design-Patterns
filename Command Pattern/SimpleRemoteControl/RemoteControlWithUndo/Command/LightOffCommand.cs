using RemoteControlWithUndo.Command.Abstractions;
using RemoteControlWithUndo.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControlWithUndo.Command
{
   public class LightOffCommand:ICommand
    {
        Light light;

        public LightOffCommand(Light _light)
        {
            light = _light;
        }

        public void Excute()
        {
            light.Off();
        }

        public void Undo()
        {
            light.On();
        }
    }
}
