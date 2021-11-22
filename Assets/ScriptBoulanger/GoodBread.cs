using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoodBread : MonoBehaviour
{
    public TextMeshPro breadTaste;
    public GameObject goodBread;
    public GameObject badBread;
    public float levelOfFarine;
    private float levelOfLevure;
    private float levelOfBeure;
    private float levelOfEau;
    private float levelOfSel;
    private bool oneBread = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (BoulangerSceneChanger.isPressed == true)
        {
            levelOfFarine = FilltheBecher.farine;
            levelOfLevure = FilltheBecher.levure;
            levelOfBeure = FilltheBecher.beure;
            levelOfEau = FilltheBecher.eau;
            levelOfSel = FilltheBecher.sel;
        }

        if (oneBread)
        {

            Debug.Log(FilltheBecher.farine);
            Debug.Log(FilltheBecher.levure);
            Debug.Log(FilltheBecher.beure);
            Debug.Log(FilltheBecher.eau);
            Debug.Log(FilltheBecher.sel);

            createBread();



            oneBread = false;
            //score = Manager.score;
            //scoreText.text = "score: " + score;
            //life = Manager.life;
            //lifeText.text = life + " Life";

        }

    }

    

    public void createBread()
    {
        

        Vector3 position = new Vector3(0f, 0f, 0f);

        if( levelOfFarine > 0.7f && levelOfFarine < 0.8f && levelOfLevure >0.4f && levelOfLevure < 0.5f && levelOfBeure > 0.2f && levelOfBeure < 0.3f && levelOfEau > 0.1f && levelOfEau < 0.2f && levelOfSel < 0.1f && SetFireToTheBread.isPerfect)
        {
            GameObject item = Instantiate(goodBread, position, Quaternion.identity);
        }

        else
        {
            GameObject item = Instantiate(badBread, position, Quaternion.identity);
        }


    }
}
