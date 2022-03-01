using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecoratorSample.Beverage;

namespace DecoratorSample.Decorator
{
    class Sugar : DobavkiDecoratorBase
    {

        BeverageBase _beverageBase;

        public Sugar(BeverageBase beverageBase)
        {
            _beverageBase = beverageBase;
            Desctiption = beverageBase.GetDescription() + " WITH sugar";

        }

        public override double GetCost()
        {
            return _beverageBase.GetCost() + 0.5;
        }
    }
}
