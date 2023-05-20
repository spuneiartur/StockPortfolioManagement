using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect.Entities
{
    public class Portfolio
    {
        readonly int id;
        public int clientId { get; private set; }
        public Portfolio(int id, int clientId)
        {
            this.id = id;
            this.clientId = clientId;
        }

        public int getId() { return id; }   
        
    }
}
