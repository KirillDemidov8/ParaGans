using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Ссылка на объект игрока
    public Vector3 offset; // Смещение камеры относительно игрока
    public float smoothSpeed = 0.125f; // Скорость сглаживания движения камеры

    void LateUpdate()
    {
        // Вычисляем новую позицию камеры
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Обновляем позицию камеры
        transform.position = smoothedPosition;

        // (Опционально) Можно зафиксировать камеру по оси Y, если нужно
        transform.position = new Vector3(transform.position.x, transform.position.y, -10f); // Например, для 2D
    }
}