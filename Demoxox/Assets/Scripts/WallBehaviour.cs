using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour
{
    [SerializeField] string wallSign;
    public Vector3 afterCollisionPush;
    private void OnCollisionEnter(Collision collision)
    {
        collision.other.gameObject.GetComponent<BallBehaviour>().sign = wallSign;
    }

}
