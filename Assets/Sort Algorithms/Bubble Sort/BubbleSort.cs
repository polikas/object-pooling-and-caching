using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{

    int[] arr = new int[1000];
    int howMany;
    // Start is called before the first frame update
    void Start()
    {
        MakeArray(arr);
        BubbleSortAlgorithm(arr);
        Debug.Log("Buble Sort Algo " + howMany);
    }

    void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                howMany++;
                if (arr[j] > arr[j + 1])
                {
                    //swap temp and arr[i]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    void MakeArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            arr[i] = Random.Range(1, 999);
            
        }
    }
}
