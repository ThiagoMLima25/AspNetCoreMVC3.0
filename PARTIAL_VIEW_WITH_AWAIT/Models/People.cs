﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PARTIAL_VIEW_WITH_AWAIT.Models
{
    public class People
    {
        public int PeopleId { get; set; }
        
        [DisplayName("Name")]
        public string PeopleName { get; set; }
        
        [DisplayName("Age")]
        public int PeopleAge { get; set; }
    }
}
