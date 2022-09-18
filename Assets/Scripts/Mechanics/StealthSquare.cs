using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealthSquare : MonoBehaviour
{
    public static bool stealthOn = false;

    private void Start()
    {
        InvokeRepeating("StealthRevoked", 0, 5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            stealthOn = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            stealthOn = false;
        }
    }

    void StealthRevoked()
    {
        Destroy(gameObject, 5);
        stealthOn = false;
    }
    
}
