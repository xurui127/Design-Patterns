using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
   public class StereoOffCommand:ICommand
    {
        Stereo stereo;

        public StereoOffCommand(Stereo _stereo)
        {
            stereo = _stereo;
        }
        public void Excute()
        {
            stereo.Off();
        }
        public void Undo()
        {
            stereo.On();
        }
    }
}
