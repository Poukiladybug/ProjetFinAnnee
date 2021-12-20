using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextFireGameplay : MonoBehaviour
{
    public TextMeshProUGUI text;
    private List<string> phrases = new List<string>();
    public GameObject button;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "La Grand Place de Bruxelles!  La plus belle place au monde selon Victor Hugo!";
        phrases.Add("La Grand Place de Bruxelles!  La plus belle place au monde selon Victor Hugo!");
        phrases.Add("Et dire qu'au tout début c'était une modeste place de marcher.");
        phrases.Add("Pour découvrir l'histoire de la place.  Sauve les citoyens de l'incendie!");
        phrases.Add("Bouge les sauveteurs à l'aide des flèches directionnelles.");
        phrases.Add("Si 3 citoyens meurent, c'est perdu!  Alors fais attention!");
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
            Change("BruxellesOnFire");
        }



    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
    }
}
