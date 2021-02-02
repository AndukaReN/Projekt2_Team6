using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_button : MonoBehaviour
{
    Renderer rend;

    public static bool move = false;

    public string button_text = "Stop";

    public void moveChar()
    {
        if (move == false)
            move = true;
        else
            move = false;

        Debug.Log("moveChar: " + move);
    }

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    
    public void SetText(string text)
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

           // if (hit.collider != null)
            {
              //  if (hit.collider.gameObject == gameObject)
                   //if( gameObject.CompareTag("guziczek"))
                {
                    Debug.Log("Guziczek wciśnięty");

                    if (button_text == "Stop")
                    {
                        SetText("Stop");
                        button_text = "Start";
                    }
                    else
                    {
                        SetText("Start");
                        button_text = "Stop";
                    }


                }
            }
        }
    }
}
