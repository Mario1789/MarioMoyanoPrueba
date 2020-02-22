using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractiveElement : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public bool push;

    public void OnPointerDown(PointerEventData eventData)
    {
        push = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        push = false;
    }
}
