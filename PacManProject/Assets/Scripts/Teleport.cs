using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform position2Teleport;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        other.transform.position = position2Teleport.position;
        other.gameObject.SetActive(true);
    }
}
