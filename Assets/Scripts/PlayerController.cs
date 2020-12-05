using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerForce = 1.0f;   //Fuerza de movimiento

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //      CONTROLES
        GetComponent<Rigidbody>().AddForce((transform.right * playerForce * -Input.GetAxis("Horizontal")) + (transform.forward * playerForce * -Input.GetAxis("Vertical")));
    }
}
