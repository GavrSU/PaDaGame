using UnityEngine;

public class Medkit : MonoBehaviour
{
    public int healAmount = 20; // Количество HP, которое восстанавливает аптечка

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что объект, вошедший в триггер, имеет тег "Player"
        if (other.CompareTag("Player"))
        {
            // Получаем компонент Health у игрока
            Health playerHealth = other.GetComponent<Health>();

            if (playerHealth != null)
            {
                // Восстанавливаем здоровье
                playerHealth.PlusHp(healAmount);

                // Уничтожаем аптечку после использования
                Destroy(gameObject);
            }
        }
    }
}
