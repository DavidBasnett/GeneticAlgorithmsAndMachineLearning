using System.Collections.Generic;

namespace Calculations
{
    public interface ICategorisedValue<C>
    {
        C Category { get; }
        List<double> Value { get; }
    }
}