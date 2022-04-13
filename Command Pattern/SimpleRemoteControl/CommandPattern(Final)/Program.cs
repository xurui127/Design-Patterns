using CommandPattern_Final_.Command;
using CommandPattern_Final_.Command.Abstraction;
using CommandPattern_Final_.Invoke;
using CommandPattern_Final_.Receiver;
using System;

namespace CommandPattern_Final_
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light("Living Room");
            TV tv = new TV("Living Room");
            Stereo stereo = new Stereo("Living Room");
            Hottub hottub = new Hottub();

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            TVOnCommand tVOn = new TVOnCommand(tv);
            HottubOnCommand hottubOn = new HottubOnCommand(hottub);

            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            TVOffCommand tvOff = new TVOffCommand(tv);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { lightOn, stereoOn, tVOn, hottubOn };
            ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(0, partyOnMacro, partyOffMacro);
            Console.WriteLine(remote);
            Console.WriteLine( "----- Macro Pushing On ------");
            remote.OnButtonWasPushed(0);
            remote.UndoButtonWasPushed();
            Console.WriteLine(remote);
            Console.WriteLine( "----- Macro Pushing Off ------");
            remote.OffButtonWasPushed(0);
            remote.UndoButtonWasPushed();
            Console.WriteLine(remote);
        }

    }
}

