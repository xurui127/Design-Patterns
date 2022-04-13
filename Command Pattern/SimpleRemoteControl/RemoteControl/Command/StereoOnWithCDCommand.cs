using RemoteControl.Command.Abstractions;
using RemoteControl.Receiver;
using System;
using System.Collections.Generic;
using System.Text;


namespace RemoteControl.Command
{
    public class StereoOnWithCDCommand : ICommand
    {
        Stereo stereo;

        public StereoOnWithCDCommand(Stereo _stereo)
        {
            stereo = _stereo;
        }
        public void Excute()
        {
            stereo.SetCD();
        }
    }
}
