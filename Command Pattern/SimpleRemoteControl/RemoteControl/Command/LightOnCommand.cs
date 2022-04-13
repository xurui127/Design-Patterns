using RemoteControl.Command.Abstractions;
using RemoteControl.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Command
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
