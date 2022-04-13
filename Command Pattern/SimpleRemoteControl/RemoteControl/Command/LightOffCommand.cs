using RemoteControl.Command.Abstractions;
using RemoteControl.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Command
{
   public class LightOffCommand :ICommand
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

    }
}
