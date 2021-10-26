using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JumperProperties : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ground"))
        {
            //    score += value;
            //    PlayerPrefs.SetInt("score", score);
            Destroy(gameObject);
            Manager.LoseLife();
            Debug.Log(Manager.life);
            
        }
    }

    
}
