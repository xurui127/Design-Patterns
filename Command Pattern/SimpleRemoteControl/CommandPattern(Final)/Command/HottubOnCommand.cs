using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
  public  class HottubOnCommand:ICommand
    {
        private Hottub hottub;
        public HottubOnCommand(Hottub _hottub)
        {
            hottub = _hottub;
        }
        public void Excute()
        {
            hottub.On();
            hottub.SetTemperature(100);
            hottub.Circulate();
        }
        public void Undo()
        {
            hottub.Off();
        }
    }
}
