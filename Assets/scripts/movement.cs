using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void Start()
    {
        // Debug.Log("Hello");
        // rb.useGravity = false;
        // rb.AddForce(0,200,500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce *Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -0.1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
