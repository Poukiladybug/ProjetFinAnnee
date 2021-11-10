using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArcherController : MonoBehaviour

{
    private PlayerActions playerInput;
    private Rigidbody2D rb;
    public GameObject bullet;
    public float vertical_speed = 5f;


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
        Vector2 moveInput = playerInput.ArcherGameplay.Movement.ReadValue<Vector2>();
        rb.MovePosition((moveInput / Screen.width)*11);
        // moveInput re�oit une position globale de la souris, c'est � dire relative � la width totale du jeu, pas par rapport � l'�cran de jeu.  C'est pour �a qu'on divise par la largeur de l'�cran et multiplie ensuite par la largeur de l'�cran de jeu

    }

    private void Shoot()
    {
        Vector2 position = ((playerInput.ArcherGameplay.Movement.ReadValue<Vector2>())/ Screen.width)*11;
        position.y = -4;
        GameObject item = Instantiate(bullet, position, Quaternion.identity);

               
    }

    private void Update()
    {
        if (playerInput.ArcherGameplay.Shoot.triggered)
        {
            Shoot();
            
        }
    }

    //private void Update()
    //{
    //    if (playerInput.Gameplay.Pause.triggered)
    //    {
    //        Pause();
    //        isPaused = !isPaused;
    //    }
    //    }
    //}


}
