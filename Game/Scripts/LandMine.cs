using UnityEngine;

public class LandMine : MonoBehaviour
{
    
    public float explosionRadius = 5f; // Радиус взрыва
    public float damage = 700f; // Сила взрыва
    public GameObject explosionEffect; // Префаб эффекта взрыва
    private bool hasExploded = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasExploded && other.CompareTag("Player"))
        {
            Explode();
        }
    }

    private void Explode()
    {
        Debug.Log(explosionEffect);
        hasExploded = true;

        // Воспроизвести звук взрыва
        GetComponent<AudioSource>().Play();

        // Воспроизвести визуальный эффект
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }

        // Нанести урон всему в радиусе
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider nearby in colliders)
        {
            Health health = nearby.GetComponent<Health>();
            if (health != null)
            {
                health.MinusHp(damage);
            }
        }

        // Удалить мину после взрыва
        Destroy(gameObject, 0.1f);
    }
}
