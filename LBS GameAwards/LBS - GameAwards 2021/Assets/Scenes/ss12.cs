using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



    public class ss12 : MonoBehaviour
{ 
    public int DeathDisplay = 0;

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
        DeathCounter.DeathPlus();
    }
}