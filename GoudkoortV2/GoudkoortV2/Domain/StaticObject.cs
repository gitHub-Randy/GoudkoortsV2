using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public abstract class StaticObject
    {
        protected StaticObject _next { get; set; }
        protected LoadableObject _object { get; set; }
    }
}