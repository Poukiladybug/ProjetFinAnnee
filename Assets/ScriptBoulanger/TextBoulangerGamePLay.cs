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
        text.text = "Vois � ta gauche la maison du Roy d'Espagne!  C'�tait la corporation des boulangers. \nA droite, c'est la maison du roi, bien qu'aucun roi n'aie jamais habit� l�...";
        phrases.Add("Vois � ta gauche la maison du Roy d'Espagne!  C'�tait la corporation des boulangers. \nA droite, c'est la maison du roi, bien qu'aucun roi n'aie jamais habit� l�...");
        phrases.Add("La maison du roi �tait, il y a bien longtemps, le magasin des boulangers. D'ailleur en n�erlandais on appelle ce b�timent 'Broodhuis', la maison du pain");
        phrases.Add("Pour en connaitre plus sur l'histoire de ces b�timents, il te faudra suivre une recette et cr�er un pain parfait! 750g de farine, 42g de levure, 2 morceaux de beure, 40 cl d'eau et 4 pinc�es de sel te seront n�cessaires");
        phrases.Add("Dose bien si tu ne veux pas avoir un mauvais pain!  Pour cel�, il te suffit de cliquer une fois sur un doseur pour commencer � le remplir.  Puis une autre fois pour arr�ter.");
        phrases.Add("Si tu en as mis trop ou trop peu, tu pourras toujours recommencer en appyant sur 'Restart'. Si tu penses avoir bien dos�, tu pourras mettre ta pr�paration au four.");
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