using RemoteControlWithUndo.Command;
using RemoteControlWithUndo.Command.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;


namespace RemoteControlWithUndo.Invoke
{
   public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand unDoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            unDoCommand = noCommand;
        }
        
        public void SetCommand(int slot, ICommand _onCommand,ICommand _offCommand)
        {
            onCommands[slot] = _onCommand;
            offCommands[slot] = _offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Excute();
            unDoCommand = onCommands[slot];
        }
        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Excute();
            unDoCommand = offCommands[slot];

        }
        public void UndoButtonWasPushed()
        {
            unDoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n ----- Remote Control ------\n");

            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append("[slot "+ i + "] " +onCommands[i].GetType().Name + "   " + offCommands[i].GetType().Name + "\n");
            }

            stringBuilder.Append(" [undo] " + unDoCommand.GetType().Name);
            return stringBuilder.ToString();
        }

    }
}
