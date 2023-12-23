using System.Linq;
using AdapterComposite.AdaptedObject;


public static class GraphDataExtension 
{
    public static int GetShiftValue(this GraphData data, int[] array)
    {
        int minValue = array.Min();
        int shift = 0 + array.Min();
        return shift;
    }
}
