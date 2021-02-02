using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colideGrav : MonoBehaviour
{
    public static bool Gravity = false;


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Gravity = true;
            Debug.Log("gravity on!!");
        }
        
    }
}
