using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

    public void ResetScore()
    {
        ScoreManager scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
        scoreManager.ResetScore();
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
