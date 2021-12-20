using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextDisplayer : MonoBehaviour
{
    public TextMeshProUGUI text;
    private List<string> phrases = new List<string>();
    public GameObject button;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Te voici devant la maison de la louve.  C'est aussi la maison des archers.  Pour en apprendre l'histoire, tu devras viser juste!";
        phrases.Add("Te voici devant la maison de la louve.  C'est aussi la maison des archers.  Pour en apprendre l'histoire, tu devras viser juste!");
        phrases.Add("Pour jouer, bouge l'arc à l'aide de ta souris. Et pour tirer utilise le click gauche.");
        phrases.Add("Sauras tu faire 100 points ou plus avant la fin du temps imparti?  A toi de jouer!");
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
            Change("MaisonDesArchers");
        }



    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
    }
}
