using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    //Para el movimiento del jugador
    /*public InputAction LeftAction;*/
    public InputAction MoveAction;
    Rigidbody2D rigidbody2D;
    Vector2 move;
    public float speed = 3.0f;

    //Para la salud del jugador
    public int maxHealth = 5;
    public int currentHealth;
    public int health {  get { return currentHealth; } }

    public float timeInvincible = 2.0f;
    bool isInvincible;
    float damageCooldown;

    // Start is called before the first frame update
    void Start()
    {
        /*LeftAction.Enable();*/
        MoveAction.Enable();
        rigidbody2D = GetComponent<Rigidbody2D>();

        //Esto sirve para bajar los frames por segundo a los que va el ordenador, para comprobar si el juego funciona al mismo tiempo
        /*QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;*/

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector2*/ move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);

        if (isInvincible )
        {
            damageCooldown -= Time.deltaTime;
            if (damageCooldown < 0 )
            {
                isInvincible = false;
            }
        }
        /*Vector2 position = (Vector2)transform.position + move * 3.0f * Time.deltaTime;
        transform.position = position;

        //variable de nombre horizontal (para controlar el movimiento horizontal en el eje x)
        float horizontal = 0.0f;
        
        float vertical = 0.0f;

        //si presonas la flecha a la derecha el horizontal pasa a ser -1
        /*if (Keyboard.current.leftArrowKey.isPressed)*/
        /*if (LeftAction.IsPressed())
        {
            horizontal = -1.0f;
        }
        //si presonas la flecha a la derecha el horizontal pasa a ser 1
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }

        else if (Keyboard.current.upArrowKey.isPressed)
        {
            vertical = 1.0f;
        }

        else if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -1.0f;
        }

        //en la consola te aparece la informaci�n de la variable horizontal
        Debug.Log(horizontal);
        Debug.Log(vertical);

        //crea un nuevo vector en 2D con el nombre position que es igual a la posici�n en la que se movi�
        Vector2 position = transform.position;

        //lleva el position uno m�s a la derecha en el 
        position.x = position.x + 0.1f * horizontal;
        position.y = position.y + 0.1f * vertical;

        //mover el personaje en el eje x hacia alante
        /*position.x = position.x + 0.1f;/*
        transform.position = position;

        //mover al personaje en el eje y hacia arriba
        /*position.y = position.y + 0.001f;*/


        //si a�ades los dos a la vez el personaje se mueve en diagonal hacia la derecha y hacia arriba
    }

    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2D.position + move * speed * Time.deltaTime;
        rigidbody2D.MovePosition(position);
    }

    public void ChangeHealth (int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
            {
                return;
            }
            isInvincible = true;
            damageCooldown = timeInvincible;
        }

        currentHealth = Mathf.Clamp (currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth +  "/" + maxHealth);
    }
}
