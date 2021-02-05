using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall02 : MonoBehaviour
{
    private Rigidbody rBody;


    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        rBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown("b")){
            rBody.useGravity = true;
        } //*/

       if( colideGrav02.Gravity02 == true)
        {
            rBody.useGravity = true;
        }
    }

}
