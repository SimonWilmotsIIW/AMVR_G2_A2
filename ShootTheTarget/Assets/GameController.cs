using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject gameMenu;
    private bool gameMenuActive;
    void Start()
    {
        gameMenuActive = false;
        gameMenu = GameObject.Find("GameMenu");
        gameMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch) && gameMenuActive==false)
        {
            gameMenu.SetActive(true);
            gameMenuActive = true;
        } else if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch) && gameMenuActive == true)
        {
            gameMenu.SetActive(false);
            gameMenuActive = false;
        }
    }
}
