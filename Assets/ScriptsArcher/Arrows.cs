using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    public Vector2 speed = Vector2.zero;
    private SpriteRenderer spriteRenderer;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vector2 start;
        Vector2 direction;

        Vector2 deplacement = speed * Time.deltaTime;
        transform.position += (Vector3)deplacement;

        if (speed.y <= 0)
        {        
            start = (Vector2)transform.position + Vector2.right * 0.51f;
            
            direction = Vector2.up;

        }    

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("target"))
        {
            //Destroy(collision.gameObject);
            //Destroy(gameObject);
            //Manager.AddScore();
            //Debug.Log(Manager.score);
            collision.transform.parent = transform;
            collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;
            collision.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            LevelManager.AddScore();
            Debug.Log(LevelManager.score);
        }
    }


}
