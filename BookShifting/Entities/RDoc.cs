﻿using System.Data;

namespace BookShifting.Entities
{
    class RDoc
    {
        public string Title{get; set;}
        public string Link {get; set;}
        public int AuthorId {get; set;}
        public DataTable rDocSpecialism {get; set;}
    }
}
