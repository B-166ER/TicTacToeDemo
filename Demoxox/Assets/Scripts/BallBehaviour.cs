using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public string sign;
    Rigidbody selfRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,5),ForceMode.Impulse );
        selfRigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("ball hit" );
        WallBehaviour wbComponent = collision.other.gameObject.GetComponent<WallBehaviour>();
        if (wbComponent != null)
        {
            selfRigidBody.velocity = Vector3.zero;
            selfRigidBody.AddForce( wbComponent.afterCollisionPush, ForceMode.Impulse );

            Debug.Log("wall");
        }
    }
}
