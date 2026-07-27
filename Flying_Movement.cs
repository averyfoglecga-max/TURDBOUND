using UnityEngine;

public class Flying_Movement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerController playerscript;
    [SerializeField] GameObject bullet;
    public float speed = 7f;
    public float damage = 1;
    public float framesBetweenShooting = 100;
    public float direction;
    new Vector2 truedirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void FixedUpdate()
    {
        if (player.transform.position.x > transform.position.x && player.transform.position.x - transform.position.x > 20)
        {
            GetComponent<Rigidbody2D>().AddForceX(speed);
        }
        if (player.transform.position.x < transform.position.x && player.transform.position.x - transform.position.x < -20)
        {
            GetComponent<Rigidbody2D>().AddForceX(speed * -1);
        }
        if (player.transform.position.y > transform.position.y && player.transform.position.y - transform.position.y > 20)
        {
            GetComponent<Rigidbody2D>().AddForceY(speed);
        }
        if (player.transform.position.y < transform.position.y && player.transform.position.y - transform.position.y < -20)
        {
            GetComponent<Rigidbody2D>().AddForceY(speed * -1);
        }
        if (framesBetweenShooting > 0)
        {
            framesBetweenShooting -= 1;
        }
        else
        {
            attack();
        }
    }
    public void die()
    {
        Destroy(gameObject);
    }
    public void attack()
    {
        GameObject nbullet = Instantiate(bullet);
        nbullet.transform.position = transform.position;
        direction = Mathf.Atan2(transform.position.y - player.transform.position.y, transform.position.x-player.transform.position.x);
        truedirection = new Vector2(Mathf.Cos(direction), Mathf.Sin(direction));
        nbullet.GetComponent<Rigidbody2D>().AddForce(truedirection * 6);
    }
}
