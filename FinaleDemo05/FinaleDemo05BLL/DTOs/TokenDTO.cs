﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo05BLL.DTOs
{
    public class TokenDTO
    {
       
        public string TKey { get; set; }
     
        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    
        public string UserId { get; set; }
    }
}