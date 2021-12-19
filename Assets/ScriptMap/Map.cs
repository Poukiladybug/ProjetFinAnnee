using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{

    private PlayerActions playerInput;
    private bool isActive = false;
    public string targetScene;
    


    private void Awake()
    {
        playerInput = new PlayerActions();
      
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    public void Change(string name)
    {
        SceneManager.LoadScene(name);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (playerInput.MapController.interact.triggered)
        {
            Change(targetScene);

        }
    }
}
