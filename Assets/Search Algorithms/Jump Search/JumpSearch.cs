using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSearch : MonoBehaviour
{
    int[] arr = new int[1000];
    int howMany;
               
    int x = 500;
    // Start is called before the first frame update
    void Start()
    {
        MakeArray(arr);
        int index = JumpSearchAlgorithm(arr, x);
        Debug.Log("Jump Search Algo " + howMany);
    }

    private int JumpSearchAlgorithm(int[] arr, int x)
    {
        int n = arr.Length;

        // Finding block size to be jumped 
        int step = (int)Math.Floor(Math.Sqrt(n));

        // Finding the block where element is 
        // present (if it is present) 
        int prev = 0;
        while (arr[Math.Min(step, n) - 1] < x)
        {
            howMany++;
            prev = step;
            step += (int)Math.Floor(Math.Sqrt(n));
            if (prev >= n)
                return -1;
        }

        // Doing a linear search for x in block 
        // beginning with prev. 
        while (arr[prev] < x)
        {
            howMany++;
            prev++;
            // If we reached next block or end of 
            // array, element is not present. 
            if (prev == Math.Min(step, n))
                return -1;
        }

        // If element is found 
        if (arr[prev] == x)
            return prev;

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
