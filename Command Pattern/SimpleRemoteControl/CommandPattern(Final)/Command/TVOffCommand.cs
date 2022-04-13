using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
 public   class TVOffCommand:ICommand
    {
        private TV tv;
        public TVOffCommand(TV _tv)
        {
            tv = _tv;
        }
        public void Excute()
        {
            tv.Off();
           
        }

        public void Undo()
        {
            tv.On();
        }
    }
}
