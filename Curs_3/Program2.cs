using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_3
{
    //definire clasa de argumente a evenimentului FireAlarm
    public class FireAlarmEventArgs : EventArgs
    {
        //campuri
        public string camera;
        public int risc;

        //constructor
        public FireAlarmEventArgs(string Camera, int Risc)
        {
            this.camera = Camera;
            this.risc = Risc;
        }
    }

    //definire clasa ce gestioneaza evenimentul alarma incendiu
    public class FireAlarm
    {
        //definire delegat - tip pointer la functie
        public delegate void FireAlarmActionDelegate(object sender, FireAlarmEventArgs e);

        //definire eveniment
        public event FireAlarmActionDelegate FireAlarmEvent = null;

        //definire functie starter a evenimentului
        public void SunaAlarma(FireAlarmEventArgs e)
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
        public void DoSomething(object sender, FireAlarmEventArgs e)
        {
            if (e.risc < 5)
            {
                Console.WriteLine("Alarma incendiu in camera " +
                    e.camera + ". Contactati telefonic camera. " +
                    "Posibil tigara aprinsa!");
            }
            else
                Console.WriteLine("Alarma incendiu in camera " +
                e.camera + ". Contactati departamentul pompieri. " +
                "Evacuati cladirea!");
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

            FireAlarmEventArgs e1 = new FireAlarmEventArgs("Camera 1", 3);
            FireAlarmEventArgs e2 = new FireAlarmEventArgs("Camera 2", 7);

            //lansare evenimente
            myFireAlarm.SunaAlarma(e1);
            myFireAlarm.SunaAlarma(e2);

            Console.Read();
        }
    }
}
