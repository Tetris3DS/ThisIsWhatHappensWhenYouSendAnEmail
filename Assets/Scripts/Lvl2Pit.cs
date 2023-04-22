using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl2Pit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //player = Player.GetComponent<Rigidbody2D>();
            // player.RigidbodyConstraints2D.FreezePositionX;
            //  player.RigidbodyConstraints2D.FreezePositionY;
            //yield return new WaitForSeconds(1);
            //deathCount++;
           // deathCountTxt.text = "Deaths : " + deathCount;
            SceneManager.LoadScene("Level2");
        }
    }
}
