using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetFireToTheBread : MonoBehaviour
{
    public float heat;
    public Image feu;
    private bool islighten = false;

    

    // Update is called once per frame
    public void SetFire(Image image)
    {
        image.fillAmount += heat;
        islighten = true;
        if (image.fillAmount >= 1f)
        {
            Change("Bread");
        }
    }

    private void Update()
    {
        if (islighten)
        {
            feu.fillAmount -= 0.001f;

            //if (feu.fillAmount < 0f)
            //{
            //    islighten = false;
            //}
        }
        
    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
    }

    }
