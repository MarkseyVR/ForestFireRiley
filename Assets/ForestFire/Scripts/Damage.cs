using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
    
{
    public float damagePlayer;
    public float damageTime = 1f; //How often I want to damge the player 
    public PlayerHealth playerHealthScript; //reference to playerhealth script
    public bool inFire;
   

    // Start is called before the first frame update
    void Start()
    {
        playerHealthScript = FindObjectOfType<PlayerHealth>(); //referencing other script player health

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        inFire = true;
        StartCoroutine(ApplyDamage()); //If in fire start the coroutine
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exit");
        inFire = false;
    }
    // Update is called once per frame
    void Update()
    {
       // if (inFire == true)
        {
           // playerHealthScript.playerCurrentHealth -= damageAmount * Time.deltaTime; // If player is in fire deduct damage every second
            
        }
    }
    public IEnumerator ApplyDamage() //Start of coroutine
    {
        Debug.Log("Coroutine started"); // Log that coroutine has started
        if ( inFire == true)
        {
            if (playerHealthScript.playerCurrentHealth <= 0)
            {
                Debug.Log("Player health has reached 0 or below");
                StopCoroutine(ApplyDamage()); // Stop coroutine if health reaches 0 or below
            }
            else
            {
                Debug.Log("Coroutine started in fire");
                playerHealthScript.playerCurrentHealth -= damageAmount;
                Debug.Log(playerHealthScript.playerCurrentHealth);
                yield return new WaitForSeconds(damageTime);
                StartCoroutine(ApplyDamage());
            }
            

        }
        else
        {
            Debug.Log("stopping coroutine");
            StopCoroutine(ApplyDamage());
        }
    }
}
