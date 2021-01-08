using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    [SerializeField]
    private float panSpeed = 20f;
    [SerializeField]
    private float panBorderThickness = 10f;
    [SerializeField]
    private float scrollSpeed = 200f;
    [SerializeField]
    public Transform target;
    [SerializeField]
    private float smoothSpeed = 0.2f;
    [SerializeField]
    public Vector3 offset;

    [SerializeField]
    private float xMin;
    [SerializeField]
    private float xMax;
    [SerializeField]
    private float yMin;
    [SerializeField]
    private float yMax;
    [SerializeField]
    private float zMin;
    [SerializeField]
    private float zMax;



    private void Update()
    {
        PlaningCamera();
        /*
        if( tu dać zmienną od postaci = true )
        {
          ActionCamera();
        }
        else
        {
            PlaningCamera();
        }
        //*/

    }

    private void PlaningCamera()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            pos.y += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            pos.y -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.z += scroll * scrollSpeed * Time.deltaTime * 100f;


        pos.x = Mathf.Clamp(pos.x, xMin, xMax);
        pos.y = Mathf.Clamp(pos.y, yMin, yMax);
        pos.z = Mathf.Clamp(pos.z, zMin, zMax);


        transform.position = pos;
    }

    private void ActionCamera()
    {
        Vector3 reqPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, reqPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}
