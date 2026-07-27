using UnityEngine;

public class Melee_Movement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerController playerscript;
    public float speed = 10f;
    public float damage = 1;
    public float framesBetweenDamage = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if(player.transform.position.x > transform.position.x)
        {
            GetComponent<Rigidbody2D>().AddForceX(speed);
        }
        if (player.transform.position.x < transform.position.x)
        {
            GetComponent<Rigidbody2D>().AddForceX(speed*-1);
        }
        if(framesBetweenDamage > 0)
        {
            framesBetweenDamage -= 1;
        }
    }
    public void die()
    {
        Destroy(gameObject);
    }
    public void attack()
    {
        playerscript.health -= damage;
    }
    private void OnCollisonEnter(Collider2D collision)
    {
        if (framesBetweenDamage <= 0)
        {
            if (collision.CompareTag("Player"))
            {
                attack();
            }
        }
    }
}
