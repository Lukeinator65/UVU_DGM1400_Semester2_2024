using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 35;
    public float turnSpeed;
    void Update()
    {
      //Move the vehicle forward
      transform.Translate(Vector3.forward * Time.deltaTime * speed);
      transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
