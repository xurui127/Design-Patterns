using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
    class StereoOnCommand:ICommand
    {

        Stereo stereo;

        public StereoOnCommand(Stereo _stereo)
        {
            stereo = _stereo;
        }
        public void Excute()
        {
            stereo.On();
        }
        public void Undo()
        {
            stereo.Off();
        }
    }
}

