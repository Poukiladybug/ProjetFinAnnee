using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextManager : MonoBehaviour
{
    
    List<string> phrases = new List<string>();
    public TextMeshProUGUI dialogue;
    public GameObject button;

    private int i = 0;

  
    void Start()
    {
        if (SceneChanger.firstTime == false)
        {
            Destroy(dialogue);
            Destroy(button);
        }
        else
        {
            dialogue.text = "Bonjour visiteur et bienvenue sur la Grand Place de Bruxelles.";
        }
        phrases.Add("Bonjour visiteur et bienvenue sur la Grand Place de Bruxelles.");//1
        phrases.Add("Si tu es ici, c'est que tu as envie de découvrir l'histoire de ces lieux.");//2
        phrases.Add("Mais attention!  Il te faudra mériter ces précieuses informations et réalisant quelques défis!");//3
        phrases.Add("Clique sur le feu, la cible et le pain pour lancer les épreuves.");//4
        phrases.Add("Es tu prêt?");//5
    }

    // Update is called once per frame
    void ChangePhrase()
    {
        dialogue.text = phrases[i];
            
    }

    public void Suite()
    {
        if (i < phrases.Count -1)
        {
            i++;
            ChangePhrase();
            
        }


        else
        {
            dialogue.text = "";
            Destroy(button);
        }
        
        
        
    }
}
