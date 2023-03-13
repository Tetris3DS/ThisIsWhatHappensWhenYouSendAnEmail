using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public GameObject topTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake() 
    {
        topTimer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
