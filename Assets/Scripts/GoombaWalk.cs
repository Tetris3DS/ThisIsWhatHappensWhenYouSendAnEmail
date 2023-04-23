using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class GoombaWalk : MonoBehaviour
{
    public PlayerData PlayerData;

    private bool isFacingRight = true;
    private float horizontal;
    public float _speed = 4f;
    
    public TMP_Text deathCountTxt;
    public static int deathCount;
    public string levelName;

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector2.right * Time.deltaTime);
        if (isFacingRight == true)
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
            // Vector3 localScale = transform.localScale;
            // localScale.x *= 1f;
            // transform.localScale = localScale;
           //SpriteRenderer.flipX;
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
            //  Vector3 localScale = transform.localScale;
            //  localScale.x *= -1f;
            //  transform.localScale = localScale;
            //SpriteRenderer.flipX;
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "block")
        {
            isFacingRight = !isFacingRight;
        }

        if (collision.gameObject.tag == "Player")
       {
            //player = Player.GetComponent<Rigidbody2D>();
           // player.RigidbodyConstraints2D.FreezePositionX;
          //  player.RigidbodyConstraints2D.FreezePositionY;
            yield return new WaitForSeconds(0);
            PlayerData.addDeath();
            SceneManager.LoadScene(levelName);
        }
        if (collision.gameObject.tag == "hammer")
        {
            Destroy(gameObject);
        }
    }


}
