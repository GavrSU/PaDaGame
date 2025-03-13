using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    // Настройки движение
    public float rotationSpeed = 100f;
    
    public float moveSpeed = 5f; // Скорость движения

    // Компоненты
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody не найден! Добавьте компонент Rigidbody объекту.");
        }
    }

    void Update()
    {
        // Получаем ввод от игрока
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D или ←/→
        float moveVertical = Input.GetAxis("Vertical");     // W/S или ↑/↓

        // Создаем вектор движения
        Vector3 movement = new Vector3(0.0f, 0.0f, moveVertical);
        movement = transform.TransformDirection(movement);

        // Перемещение
        rb.velocity = movement * moveSpeed;
         transform.Rotate(0f, rotationSpeed * Time.deltaTime * moveHorizontal, 0f);

        
    }

    

}
