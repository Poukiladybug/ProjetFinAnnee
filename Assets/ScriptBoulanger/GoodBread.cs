using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


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

        if (levelOfFarine > 0.58f && levelOfFarine < 0.65f && levelOfLevure > 0.45f && levelOfLevure < 0.52f && levelOfBeure > 0.2f && levelOfBeure < 0.27f && levelOfEau > 0.45f && levelOfEau < 0.52f && levelOfSel > 0.19f && levelOfSel < 0.26f && SetFireToTheBread.isPerfect)
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

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
        
    }

    public void NextScene()
    {
        if (goodRecipe && SetFireToTheBread.isPerfect)
        {
            Change("Video");

        }

        else
        {
            Change("YouNoob");
        }
    }
}
