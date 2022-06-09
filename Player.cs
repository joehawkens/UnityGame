using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool jumpyKeyWasPressed;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) == true) {

            jumpyKeyWasPressed = true;

        }

        horizontalInput = Input.GetAxis("Horizontal");

    }

    //called every physics update

    private void FixedUpdate(){

        if (jumpyKeyWasPressed == true) {

            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpyKeyWasPressed = false;

        }
        

        GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, GetComponent<Rigidbody>().velocity.y, 0);


    }
}
