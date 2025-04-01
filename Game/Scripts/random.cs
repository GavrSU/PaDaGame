using UnityEngine;

public class RandomMaterialCube : MonoBehaviour
{
    // Массив материалов, которые будут использоваться
    public Material[] materials;

    void Start()
    {
        // Получаем компонент Renderer у куба
        Renderer cubeRenderer = GetComponent<Renderer>();

        // Проверяем, что массив материалов не пустой
        if (materials == null || materials.Length == 0)
        {
            Debug.LogError("Массив материалов пуст! Добавьте материалы в инспекторе.");
            return;
        }

        // Выбираем случайный материал из массива
        int randomIndex = Random.Range(0, materials.Length);
        Material randomMaterial = materials[randomIndex];

        // Применяем выбранный материал к кубу
        cubeRenderer.material = randomMaterial;
    }
}
