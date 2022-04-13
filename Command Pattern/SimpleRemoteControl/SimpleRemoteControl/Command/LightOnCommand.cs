using SimpleRemoteControl.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRemoteControl.Command
{
    public class LightOnCommand : ICommand
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
    }
}
