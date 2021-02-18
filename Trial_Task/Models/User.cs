using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Trial_Task.Data;

namespace Trial_Task.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        
        
        [StringLength(500)]
        public string Name { get; set; }

        public bool Active { get; set; } = false;
    }
}
