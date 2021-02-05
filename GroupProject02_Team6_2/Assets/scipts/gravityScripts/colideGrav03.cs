using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colideGrav03 : MonoBehaviour
{
    public static bool Gravity03 = false;


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Gravity03 = true;
            Debug.Log("gravity on!!");
        }
        
    }
}
