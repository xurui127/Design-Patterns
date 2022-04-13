﻿using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern_Final_.Command
{
   public class CeilingFanHighCommand:ICommand
    {
        CeilingFan fan;
        int prevSpeed;

        public CeilingFanHighCommand(CeilingFan _fan)
        {
            fan = _fan;

        }
        public void Excute()
        {
            prevSpeed = fan.GetSpeed();
            fan.High();
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

