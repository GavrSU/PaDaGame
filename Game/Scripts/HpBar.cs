using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar; // Ссылка на UI-элемент Slider
    public float maxHealth = 100f; // Максимальное значение здоровья
    private float currentHealth; // Текущее значение здоровья

    void Start()
    {
        // Инициализация здоровья
        UpdateHealthBar();
    }



    // Метод для обновления UI-элемента
    public void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            currentHealth = gameObject.GetComponent<Health>().CurrentHp;
            maxHealth = gameObject.GetComponent<Health>().MaxHp;
            healthBar.value = currentHealth / maxHealth; // Устанавливаем значение слайдера
        }
    }
}