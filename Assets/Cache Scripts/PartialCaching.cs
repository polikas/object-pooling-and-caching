using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartialCaching : MonoBehaviour
{
    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 1000; i++)
        {
            cube.GetComponent<Rigidbody>().mass = 2;
        }
    }
}
