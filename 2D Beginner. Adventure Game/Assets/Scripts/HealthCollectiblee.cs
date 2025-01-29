using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectiblee : MonoBehaviour
{
    public AudioClip collectedClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        /*Debug.Log("Object that entered the trigger: " + other);*/
        //Crea una referencia al escript, haciendo que el collider solo funcione con aquellos que tienen este script
        PlayerController controller = other.GetComponent<PlayerController>();

        //!= es no igual a; null es nada
        if (controller != null && controller.currentHealth < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            controller.PlaySound(collectedClip);
            Destroy(gameObject);
        }
    }
}
