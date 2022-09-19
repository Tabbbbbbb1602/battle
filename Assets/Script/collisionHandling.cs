using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionHandling : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // set vi tri cho player
        if(collision.gameObject.tag == "Cube")
        {
            collision.gameObject.transform.position = gameObject.transform.position;
        }
    }
}
