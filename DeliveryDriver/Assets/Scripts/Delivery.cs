using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Lol");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("What was that ?");
    }
}
