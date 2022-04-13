using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
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
