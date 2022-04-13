using SimpleRemoteControl.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRemoteControl.Invoke
{
    class RemoteControl
    {
        private ICommand slot;

        public RemoteControl() { }

        public void SetCommand(ICommand command)
        {
            slot = command;
        }
        public void ButtonWasPressed()
        {
            slot.Excute();
        }
    }
}
