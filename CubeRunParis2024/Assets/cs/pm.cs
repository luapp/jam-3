using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pm : MonoBehaviour
{
    public Rigidbody rb;
    public float fForce = 1500f;
    public float sForce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, fForce * Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
