using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
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
        transform.position = head.position + distance;
    }

    public void SpawnMenu()
    {
        distance = head.forward * spawnDistance;
        Vector3 spawnPosition = head.position + distance;
        transform.position = spawnPosition;
        transform.LookAt(new Vector3(head.position.x, transform.position.y, head.position.z));
        transform.forward *= -1;
    }
}
