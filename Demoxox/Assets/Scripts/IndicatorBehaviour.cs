using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IndicatorBehaviour : MonoBehaviour , IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] GameObject hand;
    [SerializeField] GameObject handEffector;
    [SerializeField] RaySender raySender;
    private Color originalColor;

    void UpdatePosition()
    {
        handEffector.transform.position = raySender.RayHitPosition;
        gameObject.transform.position = Camera.main.WorldToScreenPoint(hand.transform.position);
    }
    private void OnMouseDrag()
    {
        //handEffector.transform.position = 
    }

    private void Start()
    {
        gameObject.transform.position = Camera.main.WorldToScreenPoint(hand.transform.position);
        originalColor = gameObject.GetComponent<Image>().color;
    }

    public void OnDrag(PointerEventData eventData)
    {
        UpdatePosition();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        gameObject.GetComponent<Image>().color = new Color(255,0,0);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        gameObject.GetComponent<Image>().color = originalColor;
    }
}
