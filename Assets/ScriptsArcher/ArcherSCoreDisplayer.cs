using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArcherSCoreDisplayer : MonoBehaviour
{
    public LevelManager manager;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;
    public int score;
    public float timer;
    // Start is called before the first frame update
    private void Start()
    {
        if (manager == null)
        {
            manager = FindObjectOfType<LevelManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        score = LevelManager.score;
        scoreText.text = "score: " + score;
        timer = LevelManager.globalTimer;
        timerText.text = "time left: " + timer;
    }
}
