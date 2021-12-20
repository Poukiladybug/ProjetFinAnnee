using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GoodBread : MonoBehaviour
{
    
    
    public TextMeshPro breadTaste;
    public GameObject goodBread;
    public GameObject badBread;
    private float levelOfFarine;
    private float levelOfLevure;
    private float levelOfBeure;
    private float levelOfEau;
    private float levelOfSel;
    private bool oneBread = true;
    private string taste;
    private bool goodRecipe = false;
    

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

            createBread();


            oneBread = false;
            //score = Manager.score;
            //scoreText.text = "score: " + score;
            //life = Manager.life;
            //lifeText.text = life + " Life";

        }

        if (levelOfFarine > 0.7f && levelOfFarine < 0.8f && levelOfLevure > 0.4f && levelOfLevure < 0.5f && levelOfBeure > 0.2f && levelOfBeure < 0.3f && levelOfEau > 0.1f && levelOfEau < 0.2f && levelOfSel < 0.1f && SetFireToTheBread.isPerfect)
        {
            goodRecipe = true;
        }

        
    }

    

    public void createBread()
    {
        

        Vector3 position = new Vector3(0f, 0f, 0f);

        if( goodRecipe && SetFireToTheBread.isPerfect)
        {
            GameObject item = Instantiate(goodBread, position, Quaternion.identity);
            
        }

        else
        {
            GameObject item = Instantiate(badBread, position, Quaternion.identity);
        }


    }
}
