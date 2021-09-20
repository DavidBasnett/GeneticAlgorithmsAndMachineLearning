using System;

namespace Calculations.GACA
{
    public class RowGenerator
    {
        private readonly Random _random = new Random();

        public Row Generate()
        {
            var row = new Row();
            for (int i = 0; i < row.Cells.Length; i ++)
            {
                row.Cells[i] = _random.NextDouble() > 0.5;
            }
            return row;
        }
    }
}
