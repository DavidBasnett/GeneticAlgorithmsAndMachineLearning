using System.Collections.Generic;

namespace Calculations.GACA
{
    public class Row
    {
        public bool[] Cells;
        public Row()
        {
            Cells = new bool[32];
        }

        public override bool Equals(object obj)
        {
            return obj is Row row &&
                   EqualityComparer<bool[]>.Default.Equals(Cells, row.Cells);
        }

        public void Fill(bool value)
        {
            for (int index = 0; index < Cells.Length; index ++)
            {
                Cells[index] = value;
            }
        }

        public override int GetHashCode()
        {
            return -2012357342 + EqualityComparer<bool[]>.Default.GetHashCode(Cells);
        }
    }
}
