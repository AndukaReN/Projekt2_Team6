using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    private int nextmap;

    private void Start()
    {
        nextmap = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(simpledeath.isDead == true)
        {
            
            simpledeath.isDead = false;
            restart();
            colideGrav.Gravity = false;
            colideGrav01.Gravity01 = false;
            colideGrav02.Gravity02 = false;
            colideGrav03.Gravity03 = false;


        }

    }

    public void restart()
    {
        Debug.Log("reset");
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LVLnext")
        {
            SceneManager.LoadScene(nextmap);
            colideGrav.Gravity = false;
            colideGrav01.Gravity01 = false;
            colideGrav02.Gravity02 = false;
            colideGrav03.Gravity03 = false;
        }
    }
}
