using System;
using System.Collections.Generic;

namespace Builder.Product
{
    class Vehicle
    {
        private string _type;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string type)
        {
            _type = type;
        }

        // indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Vehicle type : {0}", this._type);
            Console.WriteLine("Frame : {0}", this._parts["frame"]);
            Console.WriteLine("Engine : {0}", this._parts["engine"]);
            Console.WriteLine("#Wheels : {0}", this._parts["wheels"]);
            Console.WriteLine("#Doors : {0}", this._parts["doors"]);
        }
    }
}
