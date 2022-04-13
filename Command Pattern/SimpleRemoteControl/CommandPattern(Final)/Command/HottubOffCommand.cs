using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
  public  class HottubOffCommand:ICommand
    {
        private Hottub hottub;
        public HottubOffCommand(Hottub _hottub)
        {
            hottub = _hottub;
        }
        public void Excute()
        {
            hottub.SetTemperature(80);
            hottub.Off();
        }
        public void Undo()
        {
            hottub.On();
        }
    }
}

