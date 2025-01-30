using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Projectilee : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    public float timerProyectile = 5;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.magnitude > 100.0f)
        {
            Destroy(gameObject);
        }
        timerProyectile -= Time.deltaTime;
        if (timerProyectile<= 0)
        {
            Destroy(gameObject);
            timerProyectile = 5;
        }
    }

    public void Launch (Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        EnemyController enemy = other.GetComponent<EnemyController>();
        
        if (enemy != null)
        {
            enemy.Fix();
        }
        Destroy(gameObject);
    }
}
