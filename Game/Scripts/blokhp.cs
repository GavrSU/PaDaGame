using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blokhp : MonoBehaviour
{
    private Health health;
    // Start is called before the first frame update
    void Start()
    {
     health = gameObject.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
     if(health.CurrentHp == 0)
     {
        Destroy(gameObject);
     }
    }
}
