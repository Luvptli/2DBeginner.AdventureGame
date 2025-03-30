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

    public GameObject enemies;
    public void AddEnemie()
    {
        Instantiate(enemies, new Vector2(10,10), Quaternion.identity);
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
    
