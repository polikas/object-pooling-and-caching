using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCaching : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 1000; i++)
        {
            GameObject.Find("Cube").GetComponent<Rigidbody>().mass = 2;
            GameObject.Find("Cube").GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
