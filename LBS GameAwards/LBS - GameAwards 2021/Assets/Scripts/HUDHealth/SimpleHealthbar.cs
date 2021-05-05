using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SimpleHealthbar : MonoBehaviour
{
    public Slider healthBar;
    PlayerHealth PlayerHealth; 

    void Start()
    {
        PlayerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }


    void Update()
    {
        healthBar.value = PlayerHealth.health;
    }
}
