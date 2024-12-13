using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnTriggerEnter2D  (Collider2D other)
    {
        if (other.GetComponent<Bird> () != null)
        {
            GameController.instance.BirdScored();
        }
    }
}




