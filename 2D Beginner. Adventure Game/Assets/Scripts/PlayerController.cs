using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //variable de nombre horizontal (para controlar el movimiento horizontal en el eje x)
        float horizontal = 0.0f;

        //si presonas la flecha a la derecha el horizontal pasa a ser -1
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1.0f;
        }
        //si presonas la flecha a la derecha el horizontal pasa a ser 1
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }

        //en la consola te aparece la información de la variable horizontal
        Debug.Log(horizontal);

        //crea un nuevo vector en 2D con el nombre position que es igual a la posición en la que se movió
        Vector2 position = transform.position;

        //lleva el position uno más a la derecha en el 
        position.x = position.x + 0.1f * horizontal;

        //mover el personaje en el eje x hacia alante
        /*position.x = position.x + 0.1f;/*
        transform.position = position;

        //mover al personaje en el eje y hacia arriba
        /*position.y = position.y + 0.001f;
        transform.position = position;*/

        //si añades los dos a la vez el personaje se mueve en diagonal hacia la derecha y hacia arriba

    }
}
