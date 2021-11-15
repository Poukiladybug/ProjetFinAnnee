using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodBread : MonoBehaviour
{
    private float levelOfFarine;
    private float levelOfLevure;
    private float levelOfBeure;
    private float levelOfEau;
    private float levelOfSel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BoulangerSceneChanger.isPressed == true)
        {
            levelOfFarine = FilltheBecher.farine;
            levelOfLevure = FilltheBecher.levure;
            levelOfBeure = FilltheBecher.beure;
            levelOfEau = FilltheBecher.eau;
            levelOfSel = FilltheBecher.sel;
        }
        

    }
}
