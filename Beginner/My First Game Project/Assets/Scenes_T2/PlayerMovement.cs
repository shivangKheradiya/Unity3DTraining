using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_T2 : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hellow, The Game is started.");
        // rb.useGravity = false;
        // rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
