using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drumCollider : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)
    {
        //Debug.Log("Hit something");

       // if (c.name == "Snare")
        {

           Debug.Log(gameObject.name + " is hitting " + c.name);

        }
    }
}