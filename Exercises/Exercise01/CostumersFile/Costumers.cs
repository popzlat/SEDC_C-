using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03.CostumersFile
{
   public class Costumers
    {
        public string Username { get; set; }
        public string CardNumer { get; set; }
        public string Pin { get; set; }
        public int Money { get; set; }

        public Costumers() { }

       public Costumers (string user, string card,string pin,int money  )
        {
            Username = user;
            CardNumer = card;
            Pin = pin;
            Money = money;

        }

      

        
    }


}
