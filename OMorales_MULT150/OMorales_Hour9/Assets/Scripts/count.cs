using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class count : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

 void Update()
    {
        float xMovement = Input.GetAxis ("Horizontal");
        float yMovement = Input.GetAxis ("Vertical");
        transform.Translate (xMovement, yMovement , 0);
     }

   }



