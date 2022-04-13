using RemoteControl.Command.Abstractions;
using RemoteControl.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Command
{
    class StereoOffCommand : ICommand
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
    }
}
