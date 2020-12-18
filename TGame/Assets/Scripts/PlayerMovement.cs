using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    // Update is called once per frame
    // FixedUpdate for physics stuff
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);   //add a z-axis force on the player

        if(Input.GetKey("right") || Input.GetKey("d")){
            rb.AddForce(sideForce, 0, 0 * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(Input.GetKey("left") || Input.GetKey("a")){
            rb.AddForce(-sideForce, 0, 0 * Time.deltaTime, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().EndGame();
        }

        if(rb.position.z > GameObject.FindGameObjectWithTag("End").transform.position.z)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
