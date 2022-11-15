using System;
using System.Collections.Generic;
using System.Text;

namespace Elephants
{
    class Elephant
    {
        private string _name;
        private uint _earsSize;

        public Elephant(string _name, uint _earsSize)
        {
            this._name = _name;
            this._earsSize = _earsSize;
        }

        public string ShowWhoIAm()
        {
            string showInformations;

            showInformations = "Name : " + _name + ", ears size (cm) : " + _earsSize;

            return showInformations;

        }

        public void EcouteMessage(string message)
        {
            Console.WriteLine(_name + " a entendu un message \n" );
        }
    }
}
