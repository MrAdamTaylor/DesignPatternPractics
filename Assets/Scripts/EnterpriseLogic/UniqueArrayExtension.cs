using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EnterpriseLogic;
using UnityEngine;

public static class UniqueArrayExtension 
{
    public static int[] ReturnUniqueArrayNumbers(this int[] result, int[] array)
    {
        List<int> values = new List<int>();
        FullUniqueNumbers(array, values);
        result = values.ConvertListToArray();
        return result;
    }

    public static int ReturnSizeUniqueNumbers(this int result, int[] array)
    {
        List<int> values = new List<int>();

        FullUniqueNumbers(array, values);

        result = values.Count;

        return result;
    }
        
    private static void FullUniqueNumbers(int[] numbers, List<int> values)
    {
        //TODO - ещё пример, где LINQ упростил решение задачи
        int[] distinct = numbers.Distinct().ToArray();
        for (int i = 0; i < distinct.Length; i++)
        {
            values.Add(distinct[i]);
        }
    }
}
