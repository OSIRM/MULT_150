using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbulb : MonoBehaviour
 {

    // Start is called before the first frame update
    void Start()
     {
   

     }
     
     


    // Update is called once per frame
    void Update ()
    
    {
        if (Input.GetKeyUp(KeyCode.L))
        this.GetComponent<Light>().enabled=true;
        if (Input.GetKeyDown(KeyCode.L))
        this.GetComponent<Light>().enabled=false;

      

        }
    
    
}
