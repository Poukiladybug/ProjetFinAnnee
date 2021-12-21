using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ArcherController : MonoBehaviour

{
    public AudioSource tchak;
    
    private PlayerActions playerInput;
    private Rigidbody2D rb;
    public GameObject bullet;
    public float vertical_speed = 5f;
    private float positionX ;
    private float positionY;


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
        positionX = (moveInput.x / Screen.width) * 16 -8;
        positionY = 0;
        Vector2 newMoveInput = new Vector2(positionX, positionY);
        rb.MovePosition(newMoveInput);
        // moveInput re�oit une position globale de la souris, c'est � dire relative � la width totale du jeu, pas par rapport � l'�cran de jeu.  C'est pour �a qu'on divise par la largeur de l'�cran et multiplie ensuite par la largeur de l'�cran de jeu

    }

    private void Shoot()
    {
        Vector2 moveInput = playerInput.ArcherGameplay.Movement.ReadValue<Vector2>();
        positionX = (moveInput.x / Screen.width) * 16 -8f ;
        positionY = -4;
        Vector2 newMoveInput = new Vector2(positionX, positionY);
        GameObject item = Instantiate(bullet, newMoveInput, Quaternion.identity);
        LevelManager.score -= 2;
        

               
    }

    private void Update()
    {
        if (playerInput.ArcherGameplay.Shoot.triggered)
        {
            Shoot();
            tchak.Play();
            
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
