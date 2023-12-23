using System.Collections.Generic;

namespace EnterpriseLogic
{
    public static class ConverterExtension 
    {
        public static int[] ConvertListToArray(this List<int> values)
        {
            int[] tempData = new int[values.Count];
            for (int i = 0; i < values.Count; i++)
            {
                tempData[i] = values[i];
            }
            return tempData;
        }
    }
}
