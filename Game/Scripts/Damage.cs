using UnityEngine;

public class DamageBooster : MonoBehaviour
{
    public float boostMultiplier = 2f; // Во сколько раз увеличивается урон
    public float duration = 5f; // На какое время

    private void OnTriggerEnter(Collider other)
    {
        Shooting damageable = other.GetComponent<Shooting>();
        if (damageable != null)
        {
            damageable.XDamage+=0.5f;
            Destroy(gameObject); // Уничтожаем бонус после подбора
        }
    }

}