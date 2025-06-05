using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crahhh : MonoBehaviour
{
    void Update()
    {
      if (EnemyCounter.enemyCount==0)
      {
        Destroy(gameObject);
      }
       
    }
}
