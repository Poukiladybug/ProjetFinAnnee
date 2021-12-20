using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class Manager : MonoBehaviour
{
    
    public UnityEvent whenWin;
    public UnityEvent whenLose;
    public GameObject itemPrefab;
    public GameObject player;
    public GameObject ground;
    int col= 6;
    int gapCol = 2;
    public float timer = 2f;
    public static int life = 3;
    public static int score = 0;
    public float globalTimer = 20f;
    

    public void createJumper()
    {
        int x = Random.Range(0, col);
        Vector3 position = new Vector3(x * gapCol, 0.5f, -1.5f);
        GameObject item = Instantiate(itemPrefab, position, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        life = 3;//createJumper();
        score = 0;
    }

   

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        globalTimer -= Time.deltaTime;
        if (timer <= 0)
        {
            createJumper();
            timer = 0.5f;
        }

        if (globalTimer <= 0)
        {
            whenWin?.Invoke();
            
        }
        
        if (Manager.life <= 0)
        {
            whenLose?.Invoke();
            
        }
    }

    public static void LoseLife()
    {
        life--;
    }

    public static void AddScore()
    {
        score += 10;
    }
}
