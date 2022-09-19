using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController _characterController;
    public FloatingJoySticks _floatingJoySticks;
    public float speed;
    // Start is called before the first frame update

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void FixedUpdate()
    {
        if (_floatingJoySticks.isDrag)
        {
            Move(_floatingJoySticks.direction); 
        }
    }*/

    /*private void Move(Vector2 direction)
    {
        //Debug.Log("move");
        Vector3 move = new Vector3(direction.x, 0, direction.y);
        //Debug.Log(move);
        _characterController.Move(move * speed);
    }
*/
}
