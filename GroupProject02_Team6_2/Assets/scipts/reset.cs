using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if(simpledeath.isDead == true)
        {
           // Invoke("restart", 1.0f);
        }

    }

    public void restart()
    {
        Debug.Log("reset");
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);

    }
}
