using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starter : MonoBehaviour
{

    public static bool move = false;    public void moveChar()
    {
        if (move == false)
            move = true;
        else
            move = false;

        Debug.Log("moveChar: " + move);
    }
}
