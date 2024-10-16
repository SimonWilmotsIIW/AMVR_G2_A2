using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        //transform.rotation = Quaternion.Euler(0, player.rotation.eulerAngles.y, 0);
    }
}
