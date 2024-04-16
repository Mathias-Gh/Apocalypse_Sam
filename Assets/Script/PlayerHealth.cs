using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    public static PlayerHealth instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerHealth dans la scène");
            return;
        }

        instance = this;
    }

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        // Cette partie est juste pour les tests, vous pouvez la retirer plus tard
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20);
        }
    }

    public void HealPlayer(int amount)
    {
        if((currentHealth + amount) > maxHealth) 
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth += amount;
        }
        
        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
            return;
        }

    }


    void Die()
    {
        // Chargement de la scène actuelle pour recommencer la partie
        Debug.Log("Le joueur est éliminé");
        Playercontroleur.instance.enabled = false;
        Playercontroleur.instance.animator.SetTrigger("Die");
        Playercontroleur.instance.rb.bodyType = RigidbodyType2D.Kinematic;
        GameOverManager.instance.OnPlayerDeath();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
