using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage=25;
    public float velosity= 5;
        public float TimeDeath=10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=transform.position+transform.forward*velosity*Time.deltaTime;
    }
    void OnCollisionEnter (Collision collision)
    {
        Debug.Log(collision.collider.tag);
        Destroy(gameObject);
        if(collision.collider.GetComponent<Health>()!=null){
            collision.collider.GetComponent<Health>().MinusHp(damage);
        }
    }
}
