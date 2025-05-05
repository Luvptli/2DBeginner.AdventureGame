using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class EnemiesCount : MonoBehaviour
{
    public int totalEnemysBroken;
    public int totalEnemysRepair;
    public TextMeshProUGUI textEnemys;

    public static EnemiesCount instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddEnemie()
    {
        totalEnemysBroken++;
        ActualizarEtqueta();
    }

    public void RemoveEnemie()
    {
        totalEnemysRepair++;
        ActualizarEtqueta();
    }

    public void ActualizarEtqueta()
    {
        textEnemys.text = totalEnemysRepair.ToString() + " / " + totalEnemysBroken.ToString();
    }
}
    
