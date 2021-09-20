using System.Collections;

namespace Calculations.GACA
{
    public class ECARule : Rule
    {
        private bool[] _rule = new bool[8];

        public ECARule(byte ruleNumber)
        {
            var bits = new BitArray(new byte[] { ruleNumber });
            bits.CopyTo(_rule, 0);
        }

        public override Row Apply(Row sourceRow)
        {
            var result = new Row();
            result.Fill(false);
            for (int index = 0; index < sourceRow.Cells.Length; index ++)
            {
                var state = new BitArray(3);
                if (index > 0) { state[2] = sourceRow.Cells[index - 1]; }
                state[1] = sourceRow.Cells[index];
                if (index < sourceRow.Cells.Length - 1) { state[0] = sourceRow.Cells[index + 1]; }

                var ruleIndex = new int[1];
                state.CopyTo(ruleIndex, 0);
                result.Cells[index] = _rule[ruleIndex[0]];
            }
            return result;
        }
    }
}
