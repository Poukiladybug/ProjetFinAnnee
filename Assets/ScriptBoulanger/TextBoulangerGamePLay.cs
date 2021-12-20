using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextBoulangerGamePLay : MonoBehaviour
{
    public TextMeshProUGUI text;
    private List<string> phrases = new List<string>();
    public GameObject button;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Vois à ta gauche la maison du Roy d'Espagne!  C'était la corporation des boulangers. \nA droite, c'est la maison du roi, bien qu'aucun roi n'aie jamais habité là...";
        phrases.Add("Vois à ta gauche la maison du Roy d'Espagne!  C'était la corporation des boulangers. \nA droite, c'est la maison du roi, bien qu'aucun roi n'aie jamais habité là...");
        phrases.Add("La maison du roi était, il y a bien longtemps, le magasin des boulangers. D'ailleur en néerlandais on appelle ce bâtiment 'Broodhuis', la maison du pain");
        phrases.Add("Pour en connaitre plus sur l'histoire de ces bâtiments, il te faudra suivre une recette et créer un pain parfait! 750g de farine, 42g de levure, 2 morceaux de beure, 40 cl d'eau et 4 pincées de sel te seront nécessaires");
        phrases.Add("Dose bien si tu ne veux pas avoir un mauvais pain!  Pour celà, il te suffit de cliquer une fois sur un doseur pour commencer à le remplir.  Puis une autre fois pour arrêter.");
        phrases.Add("Si tu en as mis trop ou trop peu, tu pourras toujours recommencer en appyant sur 'Restart'. Si tu penses avoir bien dosé, tu pourras mettre ta préparation au four.");
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
            Change("Boulangers");
        }



    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
    }
}