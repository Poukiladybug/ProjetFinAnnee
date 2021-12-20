using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class LevelManager : MonoBehaviour
{
    
    public UnityEvent whenTimesOver;
    public UnityEvent WhenYourANoob;
    public GameObject targets;
    public GameObject player;
    int col = 12;
    int gapCol = 1;
    public float timeBeforeSpawn = 0.5f;
    private float timer = 1f;

    public static int score;
    public static float globalTimer;
    

    public void createTarget()
    {
        int x = Random.Range(-col/2, col/2);
        Vector3 position = new Vector3((x * gapCol)+1, 6f, -1.5f);
        GameObject item = Instantiate(targets, position, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        globalTimer = 20f;
        Vector2 startingPoint = new Vector2(0, -4.50f);
        GameObject item = Instantiate(player, startingPoint, Quaternion.identity);
    }



    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        globalTimer -= Time.deltaTime;
        if (timer <= 0)
        {
            createTarget();
            timer = timeBeforeSpawn;
        }

        if (globalTimer <= 0)
        {
            if (score >= 100)
            {
                whenTimesOver?.Invoke();
            }
            else
            {
                WhenYourANoob?.Invoke();
            }
            
            
        }

        
    }

    
    public static void AddScore()
    {
        score += 10;
    }
}
