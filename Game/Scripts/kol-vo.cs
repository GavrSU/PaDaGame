using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    public static int enemyCount;

    void Update()
    {
        // Обновляем количество врагов каждый кадр (или при необходимости)
        enemyCount = FindObjectsOfType<Enemy>().Length;
        Debug.Log("Количество врагов: " + enemyCount);
    }
}
