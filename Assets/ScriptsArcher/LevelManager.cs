using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public UnityEvent whenWin;
    public UnityEvent whenLose;
    public GameObject targets;
    public GameObject player;
    int col = 12;
    int gapCol = 1;
    public float timeBeforeSpawn = 0.5f;
    private float timer = 1f;
    public static int life = 3;
    public static int score = 0;
    public float globalTimer = 20f;

    public void createTarget()
    {
        int x = Random.Range(0, col);
        Vector3 position = new Vector3(x * gapCol, 6f, -1.5f);
        GameObject item = Instantiate(targets, position, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 startingPoint = new Vector3(5.5f, -4.75f, 0f);
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
