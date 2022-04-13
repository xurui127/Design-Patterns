using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
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

