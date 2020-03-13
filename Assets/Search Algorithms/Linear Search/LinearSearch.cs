using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearSearch : MonoBehaviour
{

    int[] arr = new int[1000];
    int howMany;

    int x = 500;
    // Start is called before the first frame update
    void Start()
    {
        MakeArray(arr);
        int index = LinearSearchAlgorithm(arr, x);
        Debug.Log("Linear Search Algo " + howMany);
    }

    private int LinearSearchAlgorithm(int[] arr, int x)
    {
        int n = arr.Length;
        for(int i = 0; i < n; i++)
        {
            howMany++;
            if(arr[i] == x)
            {
                return i;
            }
        }

        return -1;
    }

    void MakeArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            arr[i] = i;

        }
    }
}
