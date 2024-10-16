using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameMenu;
    public GameObject raycastInteraction;
    private bool gameMenuActive;
    void Start()
    {
        raycastInteraction.SetActive(false);
        gameMenuActive = false;
        gameMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch) && gameMenuActive == false)
        {
            raycastInteraction.SetActive(true);
            gameMenu.SetActive(true);
            gameMenuActive = true;
        }
        else if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch) && gameMenuActive == true)
        {
            raycastInteraction.SetActive(false);
            gameMenu.SetActive(false);
            gameMenuActive = false;
        }
    }
}
