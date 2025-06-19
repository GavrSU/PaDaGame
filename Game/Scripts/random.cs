using UnityEngine;

public class RandomMaterialCube : MonoBehaviour
{
    // Массив материалов, которые будут использоваться
    public GameObject[] prefabs;

    void Start()
    {       
        // // Проверяем, что массив материалов не пустой
         if (prefabs == null || prefabs.Length == 0)
         {
             Debug.LogError("Массив префабов пуст! Добавьте префабы в инспекторе.");
             return;
         }

         // Выбираем случайный материал из массива
         int randomIndex = Random.Range(0, prefabs.Length);
         GameObject randomPrefabs = prefabs[randomIndex];

        // // Применяем выбранный материал к кубу
         //cubeRenderer.material = randomMaterial;
         Instantiate(prefabs[randomIndex],transform.position,transform.rotation);
         Destroy(gameObject);
    }
}