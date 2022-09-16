using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


[System.Serializable]
public class FloatingJoySticks : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{ 
    //public RectTransform Background;
    //public RectTransform Handle;

    Vector2 JoyPosition;
    public Vector2 direction;

    // Start is called before the first frame update

    public bool isDrag = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("EventData " + eventData);
        OnDrag(eventData);
        JoyPosition = eventData.position;
        //Debug.Log( "Direction " + JoyPosition);
        isDrag = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log(gameObject.transform.position);
        Vector2 JoyDirection = eventData.position - JoyPosition;
        if (Vector2.Distance(eventData.position, JoyPosition) >= 20f)
        {
            direction = JoyDirection.normalized;
        }
        else
        {
            direction = Vector2.zero;
        }
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        direction = Vector2.zero;
        isDrag = false;
    }
}
