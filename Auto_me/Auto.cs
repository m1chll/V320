using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_me;

public class Auto
{
    public void Anlassen()
    {
        Console.WriteLine("Auto anlassen");

        Motor TeslaMotor = new Motor();
        TeslaMotor.Starten();
    }
}
