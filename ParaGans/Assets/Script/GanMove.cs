using UnityEngine;

public class GanMove : MonoBehaviour
{

    public float rotationSpeed = 5f; // Скорость вращения
    private Vector3 direction;

    void Update()
    {
        // Получаем позицию мыши в мировых координатах
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        direction = mousePosition - transform.position;

        // Убираем компонент Z, чтобы объект поворачивался только по оси Z
        direction.z = 0;
        direction.Normalize(); // Нормализуем вектор

        // Если направление не нулевое, поворачиваем объект
        if (direction != Vector3.zero)
        {
            // Вычисляем угол поворота по оси Z
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Создаем кватернион для поворота
            Quaternion targetRotation = Quaternion.Euler(0, 0, angle);

            // Плавно поворачиваем объект к целевому вращению
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
    public Vector2 GetDirection()
    {
        return direction;
    }
}

