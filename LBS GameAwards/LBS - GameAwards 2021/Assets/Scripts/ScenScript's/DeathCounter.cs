using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    public static int Deaths;

    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }

   public static void DeathPlus()
    {
        Deaths++;
        Debug.Log(Deaths);
    }
}
