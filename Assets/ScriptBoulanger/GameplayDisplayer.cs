using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayDisplayer : MonoBehaviour
{
    public TextMeshProUGUI text;
    private List<string> phrases = new List<string>();
    public GameObject button;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Maintenant au four!  Pour allumer le feu, clique sur la flamme.  Plus tu cliques, plus la température augmentera.";
        phrases.Add("Maintenant au four!  Pour allumer le feu, clique sur la flamme.  Plus tu cliques, plus la température augmentera.");
        phrases.Add("Une fois ton pain cuit, clique sur la pelle à pain pour la prendre et dépèche toi de retirer le pain avant qu'il ne soit bûlé.");
    }

    void ChangePhrase()
    {
        text.text = phrases[i];

    }

    public void Suite()
    {
        if (i < phrases.Count - 1)
        {
            i++;
            ChangePhrase();

        }


        else
        {
            Destroy(text);
            Destroy(button);
        }



    }
}
