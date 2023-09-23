using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mybirthday : MonoBehaviour
{
  void Start ()
    {
        for(int i = 1; i < 13; i=i+1)
        
        {
            if(i==2)
            {
            Debug.Log("Its my Birthday");
            }

           else
            Debug.Log(""+i);
        }
    }
}
