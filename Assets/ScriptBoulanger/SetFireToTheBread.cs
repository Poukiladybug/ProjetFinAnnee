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
    public GameObject pate;
    public GameObject pasCuit;
    public GameObject parfait;
    public GameObject carbonise;
    public bool oneBread = true;
    public bool unPain = true;
    public bool onePain = true;
    public bool unBread = true;
    private Vector3 position = new Vector3(0f, 0.38f, 0f);



    // Update is called once per frame
    public void SetFire(Image image)
    {
        image.fillAmount += heat;
        
        if (image.fillAmount >= 1f)
        {
            startTimer = true;
            mustClik = false;
            GameObject item = Instantiate(parfait, position, Quaternion.identity);
            onePain = false;
            //Change("Bread");
        }
    }

    private void Update()
    {
        
        if (mustClik)
        {
            feu.fillAmount -= 0.001f;
            
        }

        if (feu.fillAmount >= 0f)
        {
            GameObject item = Instantiate(pate, position, Quaternion.identity);
            unBread = false;
        }

        if (feu.fillAmount > 0.5f)
        {
            GameObject item = Instantiate(pasCuit, position, Quaternion.identity);
            unPain = false;
        }
        

        if (startTimer)
        {
            timer -= Time.deltaTime;
            if ((timer <= 0) && oneBread)
            {
                GameObject item = Instantiate(carbonise, position, Quaternion.identity);
                oneBread = false;
            }
        }
            
    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
    }

    }
