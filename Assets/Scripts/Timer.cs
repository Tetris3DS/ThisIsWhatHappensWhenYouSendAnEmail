using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{

    // [SerializeField] public TextMeshProUGUI timerText;

    [SerializeField] TMP_Text timerText;

    [SerializeField] public float startTime;

    float currentTime;
    bool timerStarted = false;

    public int frames = 3600;
    public int seconds = 60;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        timerText.text = currentTime.ToString();
        timerStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStarted) {
            currentTime -= Time.deltaTime;
        }

        timerText.text = currentTime.ToString("f0");

    }
}
