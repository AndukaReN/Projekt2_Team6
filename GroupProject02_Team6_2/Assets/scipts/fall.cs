using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
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

       if( colideGrav.Gravity == true)
        {
            rBody.useGravity = true;
        }
    }

}
