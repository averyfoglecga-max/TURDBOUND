using UnityEditor;
using UnityEngine;

public class Bullet_Movement : MonoBehaviour
{
    public Vector2 direction;
    public float timer = 1000;
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
        timer -= 1;
        if (timer <= 0)
        {
            die();
        }
    }
    void die()
    {
        Destroy(gameObject);
    }
}
