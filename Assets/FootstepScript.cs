using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepScript : MonoBehaviour
{
    public GameObject footstep;
    // Start is called before the first frame update
    void Start()
    {
        footstep.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            footsteps();
        }
        if(Input.GetKey("a"))
        {
            footsteps();
        }
        if(Input.GetKey("s"))
        {
            footsteps();
        }
        if(Input.GetKey("d"))
        {
            footsteps();
        }

        if(Input.GetKeyUp("w"))
        {
            stopsteps();
        }
        if(Input.GetKeyUp("a"))
        {
            stopsteps();
        }
        if(Input.GetKeyUp("s"))
        {
            stopsteps();
        }
        if(Input.GetKeyUp("d"))
        {
            stopsteps();
        }


    }

    void footsteps(){
        footstep.SetActive(true);
    }

    void stopsteps(){
        footstep.SetActive(false);
    }
}

