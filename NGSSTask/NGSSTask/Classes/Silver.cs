using NGSSTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSSTask.Classes
{
    public class Silver : ISilver, IDisposable
    {
        private double _silverCard;

        public double SilverCard
        {
            get { return _silverCard; }
            set { _silverCard = value*0.8; }
        }


        public void Dispose()
        {
            
        }
    }
}
