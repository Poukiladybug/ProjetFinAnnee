using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetFireToTheBread : MonoBehaviour
{
    public float heat;
    public Image feu;
    private bool mustClik = true;
    public float timer = 5f;
    private bool startTimer = false;

    //Mettre les GameObject en Image et à mettre dans le canvas pour que la pelle puisse interagir avec

    public GameObject pate;
    public GameObject pasCuit;
    public GameObject parfait;
    public GameObject carbonise;
    public bool oneBread = true;
    public bool unPain = true;
    public bool onePain = true;
    public bool unBread = true;
    private Vector3 position = new Vector3(0f, 0.38f, 75f);
    private GameObject item1;
    private GameObject item2;
    private GameObject item3;
    private GameObject item4;
    private float changeSceneTimer = 1.5f;
    public static bool isPerfect = false;
    public static bool undercooked = false;
    public static bool overcooked = false;

    private void Start()
    {
        item1 = Instantiate(pate, position, Quaternion.identity);
        unBread = false;
        undercooked = true;
    }

    // Update is called once per frame
    public void SetFire(Image image)
    {
        image.fillAmount += heat;
        
        if ((image.fillAmount >= 1f) && onePain)
        {
            startTimer = true;
            mustClik = false;
            Destroy(item2);
            item3 = Instantiate(parfait, position, Quaternion.identity);
            onePain = false;
            undercooked = false;
            isPerfect = true;
            //Change("Bread");
        }
    }

    private void Update()
    {
        
        if (mustClik)
        {
            feu.fillAmount -= 0.001f;
            
        }

        if ((feu.fillAmount > 0.5f) && unPain)
        {
            Destroy(item1);
            item2 = Instantiate(pasCuit, position, Quaternion.identity);
            unPain = false;
        }
        

        if (startTimer)
        {
            timer -= Time.deltaTime;
            if ((timer <= 0) && oneBread)
            {
                Destroy(item3);
                item4 = Instantiate(carbonise, position, Quaternion.identity);
                oneBread = false;
                isPerfect = false;
                overcooked = true;
            }
        }

        if (oneBread == false)
        {
            changeSceneTimer -= Time.deltaTime;
            if ( changeSceneTimer <= 0)
            {
                Change("Bread");
                BoulangerSceneChanger.isPressed = true;
            }
        }
            
    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
        BoulangerSceneChanger.isPressed = true;
    }

    

}


