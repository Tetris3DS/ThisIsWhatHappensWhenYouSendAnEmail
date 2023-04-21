using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoombaWalk : MonoBehaviour
{
    private bool isFacingRight = true;
    private float horizontal;
    public float _speed = 4f;
    
    [SerializeField]
    private Text deathCountTxt;
    private int deathCount;

    //public GameObject Deaths;
    public GameObject Player;
    private Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            yield return new WaitForSeconds(1);
            deathCount++;
            deathCountTxt.text = "Deaths : " + deathCount;
           SceneManager.LoadScene("BigTestWorld");
        }
        if (collision.gameObject.tag == "hammer")
        {
            Destroy(gameObject);
        }
    }


}
