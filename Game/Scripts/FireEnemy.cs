using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Префаб пули
    public Transform firePoint;     // Точка, откуда вылетает пуля
    public float fireRate = 1f;     // Частота стрельбы (в секундах)
    public float bulletSpeed =10f; // Скорость пули

    private Transform player;       // Ссылка на игрока
    private float timeSinceLastShot = 0f;

    void Start()
    {
        // Находим игрока по тегу
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        if (player == null)
        {
            Debug.LogError("Player not found! Make sure the player has the 'Player' tag.");
        }
    }

    void Update()
    {
        // Проверяем, существует ли игрок
        if (player == null) return;
      // Отсчитываем время до следующего выстрелa
        timeSinceLastShot += Time.deltaTime;
        if (timeSinceLastShot >= fireRate)
        {
            Shoot();
            timeSinceLastShot = 0f; //Сбрасываем таймер
        }
    }

    void Shoot()
    {
        // Создаем пулю в точке выстрела
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}