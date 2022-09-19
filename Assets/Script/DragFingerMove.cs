using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragFingerMove : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;
    public Transform cube;
    // Start is called before the first frame update

    Vector3 direction ;

    Vector3 StartPos;
    Vector3 EndPos;

    public float Power;


    void Start()
    {
        speedModifier = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);


            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedModifier
                    );
            }

            
            if(touch.phase == TouchPhase.Began)
            {
                StartPos = cube.position;
            }

            if(touch.phase == TouchPhase.Ended)
            {
                cube.GetComponent<Rigidbody>().isKinematic = false;
                EndPos = transform.position;
                Throw();
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            other.gameObject.transform.position = gameObject.transform.position;
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    void Throw()
    {
        StartPos.y = 0;
        EndPos.y = 0;
        direction = (EndPos - StartPos).normalized;
        cube.GetComponent<Rigidbody>().AddForce(direction * Power, ForceMode.Impulse);
    }
}
