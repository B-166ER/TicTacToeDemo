using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaySender : MonoBehaviour
{
    [SerializeField] Transform targetLeft;
    [SerializeField] Transform targetRight;
    Vector3 rayHitPosition;
    public Vector3 RayHitPosition
    { 
        get { return rayHitPosition; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] LayerMask layerMask;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 mouseposFar = new Vector3(Input.mousePosition.x,
                                                Input.mousePosition.y,
                                                Camera.main.farClipPlane);
            Vector3 mouseposNear = new Vector3(Input.mousePosition.x,
                                                Input.mousePosition.y,
                                                Camera.main.nearClipPlane);
            Vector3 far = Camera.main.ScreenToWorldPoint(mouseposFar);
            Vector3 near = Camera.main.ScreenToWorldPoint(mouseposNear);
            Debug.DrawRay(near, far - near, Color.red);

            RaycastHit hit;
            Ray ray = new Ray(near, far - near);
            if (Physics.Raycast(ray, out hit,Mathf.Infinity,layerMask,QueryTriggerInteraction.Collide))
            {
                if(hit.collider.gameObject.tag == "RayStopper")
                {
                    rayHitPosition = hit.point;
                    //targetLeft.position = hit.point;
                    //targetRight.position = hit.point;
                    print(hit.collider.gameObject.name + "has been destroyed!");
                }
                else
                {
                    print(hit.collider.gameObject.name + "!!!");
                }
            }

        }
    }
}
