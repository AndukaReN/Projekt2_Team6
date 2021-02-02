using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class simpledeath : MonoBehaviour
{
    public static bool isDead = false;

    void OnCollisionEnter(Collision collisionData)
    {
        if (collisionData.gameObject.tag == "Faller")
        {
            Destroy(gameObject);
            Debug.Log("kill");
            isDead = true;
        }

    }

}
