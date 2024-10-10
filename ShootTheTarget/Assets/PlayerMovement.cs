using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class PlayerMovement : MonoBehaviour
{
    private GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("OVRPlayerController");
    }

    // Update is called once per frame
    void Update()
    {
        var joyStickMovement = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick, OVRInput.Controller.LTouch);

        Transform playerTransform = player.transform;
        float fixedHeight = playerTransform.position.y;
        playerTransform.position -= (playerTransform.right * joyStickMovement.x + playerTransform.forward * joyStickMovement.y) * Time.deltaTime * speed;

        playerTransform.position = new Vector3(playerTransform.position.x, fixedHeight, playerTransform.position.z);
    }
}
