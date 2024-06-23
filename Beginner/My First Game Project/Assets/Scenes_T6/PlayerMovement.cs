using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_T6 : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float SideForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hellow, The Game is started.");
        // rb.useGravity = false;
        // rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        // Forward Force Added
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        // Right Force Added
        if (Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Left Force Added
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
