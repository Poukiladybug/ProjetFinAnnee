using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;



public class PellAPain : MonoBehaviour, IPointerClickHandler
{

    private PlayerActions playerInput;
    private Rigidbody2D rb;
    public bool isActive = false;
    private float xPosition;
    private float yPosition;

    //[SerializeField] private float speed = 10.0f;

    private void Awake()
    {
        playerInput = new PlayerActions();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    void FixedUpdate() // utilisation de la physics
    {
        if (isActive)
        {
            Vector2 moveInput = playerInput.BoulangerGameplay.TakeBread.ReadValue<Vector2>();
            //xPosition = (moveInput.x / Screen.width) * 16 +10;
            //yPosition = (moveInput.y  / Screen.height) * 12 +3;
            xPosition = (moveInput.x / Screen.width) * 16 - 8;
            yPosition = (moveInput.y / Screen.height) * 12 - 6; /* C'est le calcul / la bonne réponse */
            Vector2 newMoveInpute = new Vector2(xPosition, yPosition);
            rb.MovePosition(newMoveInpute);
            
            // moveInput reçoit une position globale de la souris, c'est à dire relative à la width totale du jeu, pas par rapport à l'écran de jeu.  C'est pour ça qu'on divise par la largeur de l'écran et multiplie ensuite par la largeur de l'écran de jeu
            
        }

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        isActive = true;
        Debug.Log(isActive);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Change("Bread");
    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
    }

}
