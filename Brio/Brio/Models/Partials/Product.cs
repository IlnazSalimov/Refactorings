﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brio.Models
{
    public partial class Product : IEntity
    {
        public int ID
        {
            get { return this.Id; }
        }
    }
}
