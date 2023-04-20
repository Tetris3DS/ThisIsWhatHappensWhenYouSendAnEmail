using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class pauseMenu : MonoBehaviour
{
    public GameObject menu;
    public Button resumeButton;
    public Button quitButton;
    
    void Awake()
    {

        resumeButton.onClick.AddListener(OnResumePressed);
        quitButton.onClick.AddListener(OnQuitPressed);
    }

    void Start() 
    {
        menu.SetActive(true);
    }


    void OnResumePressed()
    {
        menu.SetActive(false);

    }

    void OnQuitPressed()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
   
        if(Input.GetButtonDown("Cancel")){   
            menu.SetActive(true);
        }

    }
    // Keyboard.current.anyKey.wasPressedThisFrame
}
