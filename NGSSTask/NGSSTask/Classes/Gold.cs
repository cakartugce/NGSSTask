using NGSSTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGSSTask.Classes
{
    public class Gold:IGold,IDisposable
    {
        private double _goldCard;
        
        public double GoldCard
        {
            get { return _goldCard; }
            set {
                   
                _goldCard = value*0.7; 
                
            
                }
        }

        public void Dispose()
        {
            
        }
    }
}
