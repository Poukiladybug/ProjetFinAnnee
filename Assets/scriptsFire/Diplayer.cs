using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Diplayer : MonoBehaviour
{
    public Manager manager;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lifeText;
    public int score;
    public int life;
    // Start is called before the first frame update
    private void Start()
    {
        if (manager == null)
        {
            manager = FindObjectOfType<Manager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        score = Manager.score;
        scoreText.text = "score: " + score;
        life = Manager.life;
        lifeText.text = life + " Life";
    }
}
