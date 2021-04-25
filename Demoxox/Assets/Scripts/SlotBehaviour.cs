using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlotBehaviour : MonoBehaviour
{
    TextMeshPro tmproChild;
    // Start is called before the first frame update
    void Start()
    {
        tmproChild = gameObject.GetComponentInChildren<TextMeshPro>();
        tmproChild.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool slotVisible = false;
    private void OnTriggerEnter(Collider other)
    {
        if (!slotVisible)
        {
            slotVisible = true;
            tmproChild.enabled = true;
            tmproChild.text = other.gameObject.GetComponent<BallBehaviour>().sign;
            Debug.Log("aaa");
        }
        Debug.Log("qqq");
    }

}
