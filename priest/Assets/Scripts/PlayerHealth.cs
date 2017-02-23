using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 3;                              // The amount of health the player starts the game with.
    public int nAttemps = 3;
    public int currentHealth;                                   // The current health the player has.

    public Sprite life;
    public Sprite nolife;
    Animator anim;                                              // Reference to the Animator component.
    
    PlayerMovement playerMovement;                              // Reference to the player's movement.
    PlayerShooting playerShooting;                              // Reference to the PlayerShooting script.
    bool isDead;                                                // Whether the player is dead.
    bool damaged;                                               // True when the player gets damaged.

    void Awake()
    {
        // Setting up the references.
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        playerShooting = GetComponentInChildren<PlayerShooting>();

        // Set the initial health of the player.
        currentHealth = startingHealth;
    }


    void Update()
    {
        updateHealthGUI();

        // If the player has just been damaged...
        if (damaged)
        {
            anim.SetBool("Damaged", true);
            SpriteRenderer color = GetComponent<SpriteRenderer>();
            color.color = Color.red;
            // ... set the colour of the damageImage to the flash colour.
            // damageImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            anim.SetBool("Damaged", false);
            SpriteRenderer color = GetComponent<SpriteRenderer>();
            color.color = Color.white;
            // ... transition the colour back to clear.
            // damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        // Reset the damaged flag.
        damaged = false;
    }


    public void TakeDamage(int amount)
    {
        // Set the damaged flag so the screen will flash.
        damaged = true;

        // Reduce the current health by the damage amount.
        currentHealth -= amount;

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            Death();
        }
    }


    public void Death()
    {
        // Set the death flag so this function won't be called again.
        isDead = true;
        anim.SetTrigger("Die");
        nAttemps--;
        if (nAttemps > 0)
        {
            currentHealth = startingHealth;
            anim.SetTrigger("Respawn");
            isDead = false;
            playerMovement.respawn();
        }
        else
        {
            Application.LoadLevel("gameOver");
        }

        
    }

    public void heal()
    {
        nAttemps++;
    }

    void updateHealthGUI()
    {
        Image life1 = GameObject.FindGameObjectWithTag("life1").GetComponent<Image>();
        Image life2 = GameObject.FindGameObjectWithTag("life2").GetComponent<Image>();
        Image life3 = GameObject.FindGameObjectWithTag("life3").GetComponent<Image>();
        Text attemps = GameObject.FindGameObjectWithTag("attemps").GetComponent<Text>();

        attemps.text = ""+nAttemps+" x ";

        if (currentHealth == startingHealth)
        {
            life3.sprite = life;
            life2.sprite = life;
            life1.sprite = life;
        }
        if (currentHealth < 3) life3.sprite = nolife;
        if (currentHealth < 2) life2.sprite = nolife;
        if (currentHealth < 1) life1.sprite = nolife;
    }
}
