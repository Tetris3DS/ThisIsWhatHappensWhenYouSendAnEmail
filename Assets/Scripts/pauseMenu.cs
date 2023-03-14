using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class pauseMenu : MonoBehaviour
{
    public GameObject menu;
    public Button resumeButton;
    
    void Awake()
    {

        resumeButton.onClick.AddListener(OnResumePressed);
    }

    void Start() 
    {
        menu.SetActive(true);
    }


    void OnResumePressed()
    {
        menu.SetActive(false);

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
