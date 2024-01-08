using Patterns.AdapterComposite.AdaptedObject;

namespace EnterpriseLogic.GraphEnterprice
{
    public static class GraphConverter 
    {
        public static int[] ConvertToArray(this AdjacenyListStruct[] graphData)
        {
            int[] allIntData;
            int arraySize = CalculateSizeForArray(graphData);
            allIntData = new int[arraySize];
            allIntData = FillDataArray(graphData, arraySize);
            return allIntData;
        }
    
        private static int[] FillDataArray(AdjacenyListStruct[] graphData, int arraySize)
        {
            int[] tempArrayData = new int[arraySize];
            int indexValue = 0;
            int count = graphData.Length;
            for (int i = 0; i < count; i++)
            {
                tempArrayData[indexValue] = graphData[i].graph;
                indexValue++;
                for (int j = 0; j < graphData[i].neighbours.Length; j++)
                {
                    tempArrayData[indexValue] = graphData[i].neighbours[j];
                    indexValue++;
                }
            }
            return tempArrayData;
        }

        private static int CalculateSizeForArray(AdjacenyListStruct[] graphData)
        {
            int sum = 0;
            int allDataCount = graphData.Length;
            for (int i = 0; i < allDataCount; i++)
            {
                sum += 1;
                for (int j = 0; j < graphData[i].neighbours.Length; j++)
                {
                    sum += 1;
                }
            }
            return sum;
        }
    }
}
