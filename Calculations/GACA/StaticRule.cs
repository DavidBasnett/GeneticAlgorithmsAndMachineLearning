namespace Calculations.GACA
{
    public class StaticRule : Rule
    {
        public override Row Apply(Row sourceRow)
        {
            var copy = new Row();
            System.Array.Copy(sourceRow.Cells, copy.Cells, sourceRow.Cells.Length);
            return copy;
        }
    }
}
