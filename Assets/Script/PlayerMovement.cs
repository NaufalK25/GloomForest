using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference ti the Rigidbody component called "rb"
    public Rigidbody rb;
    public float speed = 5;
    // public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // We marked this as "FixedUpdate" because we are using it to mess with Physics
    void FixedUpdate(){
        Vector3 targetPos = new Vector3(0, 0, 1) * speed * Time.deltaTime;
        transform.Translate(targetPos);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // if player pressing "d" or right arrow key
        {
            // force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) // if player pressing "a" or left arrow key
        {
            // force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    
    }
}