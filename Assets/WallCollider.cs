using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollider : MonoBehaviour
{

    void OnTriggerEnter(Collider other){
     if (other.gameObject.tag == "Player"){
            Debug.Log("tp");
        //  SceneManager.LoadScene (2);
         }
    }
}
