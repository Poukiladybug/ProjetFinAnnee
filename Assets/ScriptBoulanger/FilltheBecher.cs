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
