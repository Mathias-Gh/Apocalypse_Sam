using UnityEngine;

public class ZombieChase : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public int maxHealth = 50;
    public int currentHealth;
    public float distanceBetween;
    public HealthBarEnemy healthBarEnemy;


    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBarEnemy.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.forward;
        direction.Normalize();


        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            
        }
    }
    public void TakeDamage(int damage)  
    {
        currentHealth -= damage;
        healthBarEnemy.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            //Animation of death
            //Death screen
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(20);
        }
    }
}
