using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis ("Horizontal");
        float yMovement = Input.GetAxis ("Vertical");
        transform.Translate (xMovement, yMovement , 0);
     }

     void OnTriggerEnter(Collider other)
{
    print(other.gameObject.name+"Sphere has entered");
}

    void OnTriggerStay(Collider other)
    {
    print (other.gameObject.name+ "Sphere has stayed");

    }
    void OnTriggerExit(Collider other)
    {
    print(other.gameObject.name+"Sphere has left");
    }
}
