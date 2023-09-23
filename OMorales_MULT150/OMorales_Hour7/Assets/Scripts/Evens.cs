using UnityEngine;
using System.Collections;

public class Evens: MonoBehaviour
{

    
    
    void Start ()
    {
        for(int i = 22; i < 102; i=i+2)
        {
            Debug.Log("Even numbers: " + i);
        }
    }
}
