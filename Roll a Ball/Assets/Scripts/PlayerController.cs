using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // called before rendering a frame
    void Update()
    {
        
    }

    // called before performing any physics calculations
    private void FixedUpdate()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        
        var movement = new Vector3(moveHorizontal, 0, moveVertical);
        
        rb.AddForce(movement * speed);     
    }
}
