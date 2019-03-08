using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotBehaviour : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // only if the player touch this object call the other methods
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AteDot();
            gameObject.SetActive(false);
        }
    }
}
