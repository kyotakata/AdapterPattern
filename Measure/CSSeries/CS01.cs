﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measure.CSSeries
{
    internal sealed class CS01 : CSSeriesBase // ICSSeries
    {
        public override int GetMeasure()
        {
            //色々実機にアクセスする…
            return 1000;
        }
    }
}
