using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject effectPrefab;
            public GameObject bulletPrefab; // Префаб пули
    public Transform spawnPoint; // Точка спавна пули
    public float bulletSpeed = 15f; // Скорость пули
    public float XDamage = 1; // Множитель урона
    public float fireRate = 3f; // Интервал между выстрелами (3 секунды)

    private float nextFireTime = 0f; // Время следующего выстрела

    void Update()
    {
        // Проверяем нажатие кнопки "Fire1" и время для следующего выстрела
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate; // Устанавливаем время следующего выстрела
        }
    }

    void Shoot()
    {
        // Создаем пулю
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        
        // Настраиваем урон пули
        bullet.GetComponent<Bullet>().damage *= XDamage;

        // Если у пули есть Rigidbody, задаем скорость
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        GameObject Ef=Instantiate(effectPrefab, spawnPoint.position, spawnPoint.rotation);
            Destroy(Ef,2f);
        if (rb != null)
        {
            rb.velocity = spawnPoint.forward * bulletSpeed;
        }
    }
}