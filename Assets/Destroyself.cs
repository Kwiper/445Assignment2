using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyself : MonoBehaviour
{
    public GameObject destroyedObject;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("destroyed obj");
            Destroy(gameObject);
        }
    }
}
