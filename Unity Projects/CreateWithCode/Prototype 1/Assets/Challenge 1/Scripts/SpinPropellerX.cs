using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float propellerSpeed = 300f;
    void Update()
    {
        transform.Rotate(0f, 0f, propellerSpeed * Time.deltaTime);   
    }
}
