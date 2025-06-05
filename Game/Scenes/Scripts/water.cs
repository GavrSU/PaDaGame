using UnityEngine;

public class SpeedModifier : MonoBehaviour
{
    // Настройки замедления
    public float slowDownFactor = 0.5f; // Множитель скорости (например, 0.5 = 50% от исходной скорости)
    private float originalSpeed; // Переменная для хранения исходной скорости игрока

    // Ссылка на скрипт PlayerMovement
    private PlayerMovement playerMovement;

    void Start()
    {
        // Находим компонент PlayerMovement у игрока
        playerMovement = FindObjectOfType<PlayerMovement>();
        if (playerMovement == null)
        {
            Debug.LogError("Скрипт PlayerMovement не найден! Убедитесь, что он прикреплен к игроку.");
        }
        else
        {
            // Сохраняем исходную скорость
            originalSpeed = playerMovement.moveSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что объект, вошедший в триггер, является игроком
        if (other.CompareTag("Player") && playerMovement != null)
        {
            // Замедляем игрока
            playerMovement.moveSpeed = originalSpeed * slowDownFactor;
            Debug.Log("Игрок замедлен!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Проверяем, что объект, покинувший триггер, является игроком
        if (other.CompareTag("Player") && playerMovement != null)
        {
            // Восстанавливаем исходную скорость
            playerMovement.moveSpeed = originalSpeed;
            Debug.Log("Игрок восстановил исходную скорость!");
        }
    }
}