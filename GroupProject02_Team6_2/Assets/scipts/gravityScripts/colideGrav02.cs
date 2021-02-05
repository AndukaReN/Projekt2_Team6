using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colideGrav02 : MonoBehaviour
{
    public static bool Gravity02 = false;


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Gravity02 = true;
            Debug.Log("gravity on!!");
        }
        
    }
}
