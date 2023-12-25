using AdapterComposite.OutputObject;
using UnityEngine;


public static class GraphStructDataExtension 
{
    public static void OutputGraphsConnections(this StructGraphData data)
    {
        
        for (int i = 0; i < data.GraphConections.Length; i++)
        {
            int graphIndex = i + data.shiftValue;
            string str = $"Узел {graphIndex}: Соседи: ";
            for (int j = 0; j < data.GraphConections[i].Count; j++)
            {
                string graphStr = data.GraphConections[i][j].ToString();
                str = str + graphStr + " ";
            }
            Debug.Log(str);
        }
    }
}
