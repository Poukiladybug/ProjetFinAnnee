using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jumper"))
        {
            Destroy(collision.gameObject);
            Manager.AddScore();
            Debug.Log(Manager.score);
        }
    }
}
