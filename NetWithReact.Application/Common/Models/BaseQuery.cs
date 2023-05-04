﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetWithReact.Application.Common.Models
{
    public record BaseQuery()
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public long Id { get; set; }
    }
}
