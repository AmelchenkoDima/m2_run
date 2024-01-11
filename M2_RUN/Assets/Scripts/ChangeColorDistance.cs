using UnityEngine;

public class ChangeColorByDistance : MonoBehaviour
{
    public float maxDistance = 50f; // Максимальное расстояние, на котором материал будет изменен
    public Material startMaterial; // Начальный материал
    public Material endMaterial; // Конечный материал

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = startMaterial; // Установка начального материала
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, new Vector3(0, 0, -10)); // Расстояние между объектом и целью

        // Применение изменения материала в зависимости от пройденного расстояния
        float t = Mathf.Clamp01(distance / maxDistance); // Нормализация расстояния от 0 до 1
        Material currentMaterial = t < 1f ? startMaterial : endMaterial; // Выбор текущего материала в зависимости от расстояния
        rend.material = currentMaterial; // Установка текущего материала объекта
    }
}

