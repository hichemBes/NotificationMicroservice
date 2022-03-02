using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public  class Notification
    {
          
        public Guid Id { get; set; }
        public string Objet { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string type { get; set; }

    }
}

