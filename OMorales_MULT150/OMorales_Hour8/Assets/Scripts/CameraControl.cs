using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
  // Start is called before the first frame update
    void Start()
    {}
      

    // Update is called once per frame
    void Update()
    {

        float value;
        value=Input.GetAxis("Mouse X");
        value=Input.GetAxis("Mouse Y");

      float mxVal = Input.GetAxis("Mouse X");
      float myVal = Input.GetAxis("Mouse Y");
      if (mxVal !=0)
        print("Left/ Right"+mxVal);
    if (mxVal !=0)
        print ("Up/ Down:"+myVal);


        
    }
}
