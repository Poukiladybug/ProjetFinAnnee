using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// utiliser un don't destroy on load ... pour ne pas perdre les données de la recette
//OU
// utiliser des playerspref...
//OU
// laisser comme ça?

public class FilltheBecher : MonoBehaviour, IPointerClickHandler
{
    public GameObject obj;
    public Image becher;
    private bool playerClick = false;
    private int clik = 1;
    public static float levure;
    public static float farine;
    public static float beure;
    public static float eau;
    public static float sel;
    //float filled = becher.fillAmount;

    // Start is called before the first frame update
    void Start()
    {
        becher = GetComponent<Image>();
        obj.SetActive(true);
        becher.fillAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetMouseButtonDown (pour faire fonctionner le fill)?
        if (playerClick)
        {
            becher.fillAmount += Time.deltaTime / 10;

            if (obj.CompareTag("levure"))
            {
                levure = becher.fillAmount;
            }

            if (obj.CompareTag("farine"))
            {
                farine = becher.fillAmount;
            }

            if (obj.CompareTag("beure"))
            {
                beure = becher.fillAmount;
            }

            if (obj.CompareTag("eau"))
            {
                eau = becher.fillAmount;
            }

            if (obj.CompareTag("sel"))
            {
                sel = becher.fillAmount;
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (clik >= 0)
        {
            Debug.Log("1");

            Debug.Log("2");
            playerClick = !playerClick;
            Debug.Log(clik);
            clik -= 1;
        }
        
       
        
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("3");
        //    playerClick = !playerClick;
        //}
    }
}
