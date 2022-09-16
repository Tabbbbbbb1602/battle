using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionHandling : MonoBehaviour
{
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
        Debug.Log(collision.gameObject);
        Debug.Log(gameObject.name);
        Debug.Log(gameObject.transform.position);
        collision.gameObject.SetActive(false);
        Instantiate(collision.gameObject, gameObject.transform.position, Quaternion.identity);
    }
}
