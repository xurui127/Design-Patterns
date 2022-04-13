using RemoteControl.Command;
using RemoteControl.Command.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControls.Invoke
{
   public class RemoteController
    {
        ICommand[] onCommands;
        ICommand[] offCommands;

        public RemoteController()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;

            }
        }

        public void SetCommand(int slot, ICommand _onCommand, ICommand _offCommand)
        {
            onCommands[slot] = _onCommand;
            offCommands[slot] = _offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Excute();
        }
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Excute();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n ----- Remote Control ------\n");

            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append("[slot " + i + "] " + onCommands[i].GetType().Name + "   " + offCommands[i].GetType().Name + "\n");
            }

            return stringBuilder.ToString();
        }

    }
}
