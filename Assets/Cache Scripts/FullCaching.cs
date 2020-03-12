using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullCaching : MonoBehaviour
{

    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GameObject.Find("Cube").GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 1000; i++)
        {
            rigidBody.mass = 2;
        }
    }
}
