using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertionSort : MonoBehaviour
{
    int[] arr= new int[1000];
    int howMany;
    // Start is called before the first frame update
    void Start()
    {
        MakeArray(arr);
        InsertionSortAlgorithm(arr);
        Debug.Log("Insertion Sort Algo" + howMany);
    }

    void InsertionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for(int i = 1; i < n; i++)
        {
           
            int key = arr[i];
            int j = i - 1;

            while(j >= 0 && arr[j] > key)
            {
                howMany++;
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
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
