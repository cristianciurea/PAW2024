using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_3
{
    //definire clasa ce gestioneaza evenimentul alarma incendiu
    /*public class FireAlarm
    {
        //definire delegat - tip pointer la functie
        public delegate void FireAlarmActionDelegate(object sender, EventArgs e);

        //definire eveniment
        public event FireAlarmActionDelegate FireAlarmEvent = null;

        //definire functie starter a evenimentului
        public void SunaAlarma(EventArgs e)
        {
            if (FireAlarmEvent != null)
            {
                //se apeleaza evenimentul
                FireAlarmEvent(this, e);
            }
        }
    }

    //clasa care ofera solutii pentru evenimentul FireAlarm
    public class FireAlarmHandler
    {
        //definire metoda pentru abonare la eveniment
        public void DoSomething(object sender, EventArgs e)
        {
            Console.WriteLine("Alarma incendiu. Contactati telefonic camera. Posibil tigara aprinsa!");
        }

        //definire constructor
        public FireAlarmHandler(FireAlarm alarma)
        {
            //abonare metoda proprie la eveniment
            alarma.FireAlarmEvent += new FireAlarm.FireAlarmActionDelegate(this.DoSomething);
        }
    }

    class Program
    {
        static void Main()
        {
            FireAlarm myFireAlarm = new FireAlarm();

            FireAlarmHandler handler = new FireAlarmHandler(myFireAlarm);

            EventArgs e = new EventArgs();

            //lansare evenimente
            myFireAlarm.SunaAlarma(e);

            Console.Read();
        }
    }*/
}
