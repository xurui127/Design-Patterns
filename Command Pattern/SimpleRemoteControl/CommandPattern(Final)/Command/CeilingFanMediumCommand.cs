using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
   public class CeilingFanMediumCommand :ICommand
    {
        CeilingFan fan;
        int prevSpeed;

        public CeilingFanMediumCommand(CeilingFan _fan)
        {
            fan = _fan;
        }
        public void Excute()
        {
            prevSpeed = fan.GetSpeed();
            fan.Medium();
        }

        public void Undo()
        {
            if (prevSpeed == CeilingFan.high)
            {
                fan.High();
            }
            else if (prevSpeed == CeilingFan.medium)
            {
                fan.Medium();
            }
            else if (prevSpeed == CeilingFan.low)
            {
                fan.Low();
            }
            else if (prevSpeed == CeilingFan.off)
            {
                fan.Off();
            }

        }
    }
}
