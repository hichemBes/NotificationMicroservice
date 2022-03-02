using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos
{
     public  class NotificationDto
    {
        public string Objet { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string type { get; set; }
    }
}
