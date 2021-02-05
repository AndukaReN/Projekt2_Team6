using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colideGrav01 : MonoBehaviour
{
    public static bool Gravity01 = false;


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Gravity01 = true;
            Debug.Log("gravity on!!");
        }
        
    }
}
