using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagTouch : MonoBehaviour
{
    public AudioSource flagnoise;
    public Victory Victory;

    public string nextLevelName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            flagnoise.Play();
            yield return new WaitForSeconds(0);

            Victory.activateVictory(nextLevelName);
            //SceneManager.LoadScene("LevelSelect");
        }
    }
}
