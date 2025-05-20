using UnityEngine;

public class BulletForRPG : MonoBehaviour
{
    [Header("Bullet Settings")]
    public float damage = 25f;
    public float velocity = 20f;
    public float timeToLive = 10f;

    [Header("Explosion Settings")]
    public float explosionRadius = 5f;
    public LayerMask targetLayer;

    void Start()
    {
        Destroy(gameObject, timeToLive);
    }

    void Update()
    {
        transform.position += transform.forward * velocity * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        
        Explode();

        
        Destroy(gameObject);
    }

    void Explode()
    {
        
        Collider[] nearbyColliders = Physics.OverlapSphere(transform.position, explosionRadius, targetLayer);

        foreach (Collider nearby in nearbyColliders)
        {
            Health health = nearby.GetComponent<Health>();
            if (health != null)
            {
                health.MinusHp(damage);

                
                if (nearby.CompareTag("Enemy"))
                {
                    AudioManager audioManager = nearby.GetComponent<AudioManager>();
                    if (audioManager != null)
                    {
                        audioManager.Play("Попадание");
                    }
                }
            }
        }
    }
}