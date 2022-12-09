using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerFollow : MonoBehaviour
{
    // Follow this object
    public GameObject FollowThis;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = FollowThis.transform.position;
    }
}
