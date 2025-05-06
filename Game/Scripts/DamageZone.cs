using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // Скорость наносимого урона (например, 10 HP в секунду)
    public float damagePerSecond = 10f;

    private void OnTriggerStay(Collider other)
    {
        // Проверяем, есть ли у объекта, который касается, компонент Health
        Health health = other.GetComponent<Health>();

        if (health != null)  
        {
            // Наносим урон пропорционально времени (Time.deltaTime)
            health.MinusHp(damagePerSecond * Time.deltaTime);
        }
    }
}