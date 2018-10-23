using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudkoortV2
{
    public abstract class LoadableObject
    {
        protected StaticObject _currentField { get; set; }

        protected abstract void Move();
      

        
    }
}