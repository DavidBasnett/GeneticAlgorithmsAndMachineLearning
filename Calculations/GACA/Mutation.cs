using System;

namespace Calculations.GACA
{
    public class Mutation
    {
        private readonly Random _random = new Random();
        private readonly double _rate;

        public Mutation(double rate)
        {
            _rate = rate;
        }

        public Row Execute(Row row)
        {
            if (_random.NextDouble() < _rate)
            {
                int indexToMutate = _random.Next(row.Cells.Length);
                row.Cells[indexToMutate] = !row.Cells[indexToMutate];
            }
            return row;
        }
    }
}
