using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float playerMaxHealth;
    public float playerCurrentHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerMaxHealth = 7; //set players starting/max health
        playerCurrentHealth = playerMaxHealth; 

     
    }

    // Update is called once per frame
    void Update()
    {
        if ( playerCurrentHealth <= 0) //If current health reaches 0 change scene
        {
            ChangeScene();
        }
    }
    private void ChangeScene()
    {
        SceneManager.LoadSceneAsync(1); // Load scene
    }
   
    
        
    }


