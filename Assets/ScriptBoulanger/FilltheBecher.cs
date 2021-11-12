using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class FilltheBecher : MonoBehaviour, IPointerClickHandler
{
    public GameObject obj;
    public Image becher;
    private bool playerClick = false;
    private int clik = 1;
    public static float levelOfLevure;
    public static float levelOfFarine;
    public static float levelOfEau;
    public static float levelOfBeure;
    public static float levelOfSel;
    public static bool sel = false;
    public static bool farine = false;
    public static bool levure = false;
    public static bool eau = false;
    public static bool beure = false;
    
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
        
        if (playerClick)
        {
            becher.fillAmount += Time.deltaTime / 10;

            if (obj.CompareTag("farine"))
            {
                levelOfFarine = becher.fillAmount;
                farine = true;
                Debug.Log("farine: " + farine);
            }
            else if (obj.CompareTag("levure"))
            {
                levelOfLevure = becher.fillAmount;
                levure = true;
                Debug.Log("levure: " + levure);
            }
            else if (obj.CompareTag("eau"))
            {
                levelOfEau = becher.fillAmount;
                eau = true;
                Debug.Log("eau: " + eau);
            }
            else if (obj.CompareTag("beure"))
            {
                levelOfBeure = becher.fillAmount;
                beure = true;
                Debug.Log("beure: " + beure);
            }
            else if (obj.CompareTag("sel"))
            {
                levelOfSel = becher.fillAmount;
                sel = true;
                Debug.Log("sel: " + sel);
            }
        }

            
            //Input.GetMouseButtonDown (pour faire fonctionner le fill)?
        
       
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
