using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
    public GameObject destroyedObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BreakObject();
        }
    }

    void BreakObject()
    {
        Instantiate(destroyedObject, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
