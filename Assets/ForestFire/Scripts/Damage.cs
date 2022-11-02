using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
    
{
    public float damagePlayer;
    public float damageTime = 0.05f; //How often you want damage to be done to the player
    public float currentDamageTime;
    public PlayerHealth playerHealthScript; //reference to playerhealth script
    public bool inFire;
    public float damageAmount;

    // Start is called before the first frame update
    void Start()
    {
        playerHealthScript = FindObjectOfType<PlayerHealth>(); //referencing other script player health

    }
    private void OnTriggerEnter(Collider other)
    {
        inFire = true;
    }
    private void OnTriggerExit(Collider other)
    {
        inFire = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (inFire == true)
        {
            playerHealthScript.playerCurrentHealth -= damageAmount * Time.deltaTime; // If player is in fire deduct damage every second
            
        }
    }
}
