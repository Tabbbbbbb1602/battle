using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            other.gameObject.transform.position = gameObject.transform.position;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

   /* IEnumerator Throw()
    {
        StartPos.y = 0;
        EndPos.y = 0;
        direction = (EndPos - StartPos).normalized;
        cube.GetComponent<Rigidbody>().AddForce(direction * Power, ForceMode.Impulse);
    }*/
}
