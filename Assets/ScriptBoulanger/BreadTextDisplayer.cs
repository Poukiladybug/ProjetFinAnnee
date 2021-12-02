using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BreadTextDisplayer : MonoBehaviour
{
    public TextMeshProUGUI breadTaste;
    private bool goodRecipe = false;
    public string taste;
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
        levelOfFarine = FilltheBecher.farine;
        levelOfLevure = FilltheBecher.levure;
        levelOfBeure = FilltheBecher.beure;
        levelOfEau = FilltheBecher.eau;
        levelOfSel = FilltheBecher.sel;

       
        if (levelOfFarine > 0.7f && levelOfFarine < 0.8f && levelOfLevure > 0.4f && levelOfLevure < 0.5f && levelOfBeure > 0.2f && levelOfBeure < 0.3f && levelOfEau > 0.1f && levelOfEau < 0.2f && levelOfSel < 0.1f && SetFireToTheBread.isPerfect)
        {
            goodRecipe = true;
        }

        if (goodRecipe && SetFireToTheBread.isPerfect)
        {
            taste = "WOAW!  Your bread is perfect! Sooo yumy!";
        }

        if (goodRecipe && SetFireToTheBread.overcooked)
        {
            taste = "YEURK! What have you done?  This bread is overcooked!";
        }

        if (goodRecipe && SetFireToTheBread.undercooked)
        {
            taste = "YEURK! What have you done?  This bread is undercooked!";
        }

        if (!goodRecipe && SetFireToTheBread.isPerfect)
        {
            taste = " HuH! This bread looks great but I think something went wrong with the recipe :( ";
        }

        if (!goodRecipe && SetFireToTheBread.undercooked)
        {
            taste = "Are you sure?!  It smells bad and it's not even cooked!";
        }

        if (!goodRecipe && SetFireToTheBread.overcooked)
        {
            taste = "Are you trying to kill me?!!  What have you done with the recipe?  And it's charred!!";
        }

        else
        {
            taste = "wooooops";
        }

        breadTaste.text = taste;
    }
}
