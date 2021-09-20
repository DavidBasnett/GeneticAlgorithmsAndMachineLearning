using System.Collections.Generic;

namespace Calculations.GACA
{
    public class DreamRule : Rule
    {
        private readonly RowGenerator _generator = new RowGenerator();
        private readonly Dictionary<Row, Row> _lookup = new Dictionary<Row, Row>();

        public override Row Apply(Row sourceRow)
        {
            if (_lookup.ContainsKey(sourceRow))
            {
                return _lookup[sourceRow];
            }
            var randomRow = _generator.Generate();
            _lookup.Add(sourceRow, randomRow);
            return randomRow;
        }
    }
}
