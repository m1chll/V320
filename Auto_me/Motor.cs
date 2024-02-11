using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_me;

public class Motor
{
    private Anlasser TeslaAnlasser;
    public void Starten()
    {
        Console.WriteLine("Motor starten");
        
        Benzinpumpe TeslaBenzinpumpe = new Benzinpumpe();
        TeslaBenzinpumpe.Pumpen();

        TeslaAnlasser = new Anlasser();
        TeslaAnlasser.Starten();

        Regeln();

    }

    private void Regeln()
    {
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Motor regeln");
        }

        TeslaAnlasser = new Anlasser();
        TeslaAnlasser.Stoppen();
    }

}
