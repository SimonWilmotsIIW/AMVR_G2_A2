using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Transform head;
    public float spawnDistance;
    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*distance = head.forward * spawnDistance + new Vector3(0,0.6f,0);
        Vector3 spawnPosition = head.position + distance;
        transform.position = spawnPosition;
        transform.LookAt(new Vector3(head.position.x, transform.position.y, head.position.z));
        transform.forward *= -1;*/
    }
}
