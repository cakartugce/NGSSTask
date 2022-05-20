using NGSSTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSSTask.Classes
{
    public class Customer : ICustomer, IDisposable
    {
        private double _customer;

        public double Customerr
        {
            get { return _customer; }
            set {
                value = value * 0.9;
                _customer = value;


                }
        }

        private double _customer2;

        public double Customer2
        {
            get { return _customer2; }
            set {
                value = value * 0.95;
                _customer2 = value; }
        }

        public void Dispose()
        {
            
        }
    }
}
