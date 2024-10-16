using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{   
    public GameObject menu;
    public InputActionProperty menuRevealButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(menuRevealButton.action.WasPressedThisThisFrame()) {
        //     menu.SetActive(!menu.activeSelf);
        // }
    }

    public void testButton()
    {
        Debug.Log("Button clicked");
    }
}
