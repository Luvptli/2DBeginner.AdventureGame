using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidbody2d;
    public bool vertical;
    //Para que se mueva aleatorio: Vector2 movementDirection;

    public float changeTime = 3.0f;
    float timer;
    int direction = 1;

    Animator animator;

    bool broken = true;

    AudioSource audioSource;

    public ParticleSystem smokeEffect;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;

        animator = GetComponent<Animator>();

        audioSource = GetComponent<AudioSource>();

<<<<<<< HEAD
        totalEnemysBroken = 12;
        totalEnemysRepair = 0;

        if (!gameObject.name.Contains("Confined"))
        {
            AddEnemie();
        }
=======
        //Para que se mueva aleatorio: ChangeDirection();
>>>>>>> parent of b935204 (Modificaci√≥n)
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            //Para que se mueva aleatorio: borras la lÌnea de abajo y pones ChangeDirection();
            direction = -direction;
            timer = changeTime;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!broken)
        {
            return;
        }

        Vector2 position = rigidbody2d.position;

        //Para que se mueva aleatorio: borras todo a partir de aquÌ y pones
        /*rigidbody2d.MovePosition.position
         animator.SetFloat("MoveX", movementDirection.x);
         animator.SetFloat("MoveY", movementDirection.y);*/

        if (vertical)
        {
            position.y = position.y + speed * direction * Time.deltaTime;
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
        }
        else
        {
            position.x = position.x + speed * direction * Time.deltaTime;
            animator.SetFloat("Move X", direction);
            animator.SetFloat("Move Y", 0); 
        }

        rigidbody2d.MovePosition(position);
    }

    //Para que se mueva aleatorio:
    /*void Change Direction()
    { int direction = Random.Range(0,4);
    switch (direction)
    { case 0:
     movementDirection = Vector2.left;
     break;
    case 1:
     movementDirection = Vector2.right;
     break;
    case 2:
     movementDirection = Vector2.up;
     break;
    case 1:
     movementDirection = Vector2.down;
     break;
    }
    } */

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();
        if (player !=null)
        {
            player.ChangeHealth(-1);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

    public void Fix()
    {
        broken = false;
        rigidbody2d.simulated = false;
        animator.SetTrigger("Fixed");
        audioSource.Stop();
        smokeEffect.Stop();
    }
}
