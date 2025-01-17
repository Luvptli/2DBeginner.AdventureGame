using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    /*public InputAction LeftAction;*/
    public InputAction MoveAction;
    Rigidbody2D rigidbody2D;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        /*LeftAction.Enable();
        MoveAction.Enable();*/
        rigidbody2D = GetComponent<Rigidbody2D>();
        /*QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;*/
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector2*/ move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
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
}
