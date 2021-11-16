using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;



public class PellAPain : MonoBehaviour, IPointerClickHandler
{

    private PlayerActions playerInput;
    private Rigidbody2D rb;
    public bool isActive = false;

    [SerializeField] private float speed = 10.0f;

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
            rb.MovePosition((moveInput / Screen.width) * 11);
            // moveInput re�oit une position globale de la souris, c'est � dire relative � la width totale du jeu, pas par rapport � l'�cran de jeu.  C'est pour �a qu'on divise par la largeur de l'�cran et multiplie ensuite par la largeur de l'�cran de jeu

        }

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        isActive = true;
    }
    
}
