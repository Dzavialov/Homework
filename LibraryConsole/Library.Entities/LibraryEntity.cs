﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class LibraryEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
