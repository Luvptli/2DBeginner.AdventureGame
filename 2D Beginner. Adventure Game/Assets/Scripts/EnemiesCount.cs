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

    private void Update()
    {
        textEnemys.text = totalEnemysRepair.ToString() + " / " + totalEnemysBroken.ToString();
        if (Input.GetKeyDown(KeyCode.E))
        {
            AddEnemie();
        }
    }
    public void AddEnemie()
    {
        Instantiate(enemies, new Vector2(10,10), Quaternion.identity);
        totalEnemysBroken++;
    }

    public void RemoveEnemie()
    {
        totalEnemysRepair++;
    }
}
    
