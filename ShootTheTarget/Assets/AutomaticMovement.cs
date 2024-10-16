using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticMovement : MonoBehaviour
{
    public float speed;
    float walkingDirection;
    // Start is called before the first frame update
    void Start()
    {
        walkingDirection = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z <= -2.2)
        {
            walkingDirection = speed;
        } else if (transform.position.z >= 6.0)
        {
            walkingDirection = -speed;
        }
        transform.position += new Vector3(0, 0, walkingDirection);
    }
}
