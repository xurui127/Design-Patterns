using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
  public class TVOnCommand : ICommand
    {
        private TV tv;
        public TVOnCommand(TV _tv)
        {
            tv = _tv;
        }
        public void Excute()
        {
            tv.On();
            tv.SetInputChannel();
        }

        public void Undo()
        {
            tv.Off();
        }
    }
}
