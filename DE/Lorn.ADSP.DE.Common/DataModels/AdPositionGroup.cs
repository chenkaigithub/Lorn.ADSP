﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorn.ADSP.DE.DataModels
{
    public class AdPositionGroup
    {
        public Guid AdPositionGroupId { get; set; }
        public ICollection<Guid> AdPositions { get; set; }
    }
}
