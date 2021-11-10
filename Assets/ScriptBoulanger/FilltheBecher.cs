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
        Debug.Log("1");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("2");
            playerClick = !playerClick;
            obj.SetActive(playerClick);

        }
    }
}
