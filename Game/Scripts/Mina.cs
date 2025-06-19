using UnityEngine;

public class MineExplosion : MonoBehaviour
{
    public float explosionRadius = 5f; // Радиус взрыва
    public float explosionForce = 700f; // Сила взрыва
    public GameObject explosionEffect; // Префаб эффекта взрыва

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что объект, попавший в триггер, является целью
        if      (other.CompareTag("Player") || other.CompareTag("Enemy"))
        {
            Explode();
            Destroy(gameObject); // Уничтожаем мину после взрыва
        }
    }

    private void Explode()
    {
        // Создаем эффект взрыва (если префаб задан)
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }

        // Получаем все объекты в радиусе взрыва
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider nearbyObject in colliders)
        {
            // Проверяем, есть ли у объекта Rigidbody
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Применяем силу взрыва
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }

            // Если объект имеет тег "Player" или "Enemy", наносим урон
            if (nearbyObject.CompareTag("Player") || nearbyObject.CompareTag("Enemy"))
            {
                Health health = nearbyObject.GetComponent<Health>();
                if (health != null)
                {
                    health.MinusHp(50); // Наносим 50 единиц урона
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Визуализация радиуса взрыва в редакторе
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}