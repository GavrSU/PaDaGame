using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public Health health; // Ссылка на скрипт HealthBar
    public float damageOnCollision = 10f; // Количество урона при столкновении

    private void OnCollisionEnter(Collision collision)
    {
        // Проверяем, имеет ли объект тег "Enemy" (или другой тег, который вы используете)
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Наносим урон игроку
            health.MinusHp(damageOnCollision);

            // Дополнительные действия (например, эффекты или звуки)
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Если вы используете триггеры вместо физических столкновений
        if (other.gameObject.CompareTag("Enemy"))
        {
            health.MinusHp(damageOnCollision);
        }
    }
}