//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.InputSystem;

//public class test : MonoBehaviour
//{

//    private PlayerActions playerInput;
//    private Rigidbody2D rb;
//    public bool isActive = false;
//    //public GameObject bullet;
//    //public float vertical_speed = 5f;


//    [SerializeField] private float speed = 10.0f;

//    private void Awake()
//    {
//        playerInput = new PlayerActions();
//        rb = GetComponent<Rigidbody2D>();
//    }

//    private void OnEnable()
//    {
//        playerInput.Enable();
//    }

//    private void OnDisable()
//    {
//        playerInput.Disable();
//    }

//    void FixedUpdate() // utilisation de la physics
//    {
//        if (isActive)
//        {
//            Vector2 moveInput = playerInput.test.pelle.ReadValue<Vector2>();
//            rb.MovePosition((moveInput / Screen.width) * 11);
//        }
        
//        // moveInput reçoit une position globale de la souris, c'est à dire relative à la width totale du jeu, pas par rapport à l'écran de jeu.  C'est pour ça qu'on divise par la largeur de l'écran et multiplie ensuite par la largeur de l'écran de jeu

//    }
//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }

//    private void OnMouseDown()
//    {
//        isActive = !isActive;
//    }
//}
