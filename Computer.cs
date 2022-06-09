using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("moveComputer", 1f, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }


    void moveComputer() {

        GetComponent<Rigidbody>().AddForce(Vector3.up * 6, ForceMode.VelocityChange);

    }
}
