using System.Collections.Generic;

namespace Calculations
{
    public class PositionData : ICategorisedValue<bool>
    {
        public float X { get; set; }
        public float Y { get; set; }
        public bool IsEscaped { get; set; }

        public bool Category => IsEscaped;

        public List<double> Value => new List<double> { X, Y };

        public PositionData() { }
        public PositionData(float x, float y, bool isEscaped)
        {
            X = x;
            Y = y;
            IsEscaped = isEscaped;
        }
    }
}
