using System.Linq;
using Patterns.AdapterComposite.AdaptedObject;

namespace EnterpriseLogic.GraphEnterprice
{
    public static class GraphDataExtension 
    {
        public static int GetShiftValue(this GraphData data, int[] array)
        {
            int minValue = array.Min();
            int shift = 0 + array.Min();
            return shift;
        }
    }
}
