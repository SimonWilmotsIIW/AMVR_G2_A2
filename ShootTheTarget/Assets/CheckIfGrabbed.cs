using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfGrabbed : MonoBehaviour
{
    private OVRGrabbable grabbable;
    // Start is called before the first frame update
    void Start()
    {
        grabbable = transform.GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (grabbable.isGrabbed)
        {
            Collider gunCollider = transform.GetComponent<Collider>();
            gunCollider.isTrigger = false;
        } else
        {
            Collider gunCollider = transform.GetComponent<Collider>();
            gunCollider.isTrigger = true;
        }
    }
}
