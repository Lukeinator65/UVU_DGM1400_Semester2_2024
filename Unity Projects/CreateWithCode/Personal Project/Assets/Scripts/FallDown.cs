using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    public float Speed = 1.0f;
    private Rigidbody objectRb;

    // Start is called before the first frame update
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.down * Speed);
    }
}
