using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorSample.Beverage;

namespace DecoratorSample.Decorator
{
    class Milkers: DobavkiDecoratorBase
    {
        BeverageBase _beverageBase;
        public Milkers (BeverageBase beverageBase)
        {
            _beverageBase = beverageBase;
            Desctiption = beverageBase.GetDescription() + " WITH milk";

        }

        public override double GetCost()
        {
            return _beverageBase.GetCost() + 25.0;
        }
    }
}
