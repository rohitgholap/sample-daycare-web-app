using System;
using System.Collections.Generic;

namespace Daycare.Repository.Entities
{
    public class Children
    {
       public string first_name { get; set; }
       public string middle_name { get; set; }
       public string last_name { get; set; }
       public DateTime date_of_birth { get; set; }
       public string gender { get; set; }
       public Guid correlation_id { get; set; }     

    }
}

