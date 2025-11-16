using UnityEngine;

public class Enamy : MonoBehaviour
{
    private float damage = 10;
    private float hp = 20;

   

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("x");
        if (other.gameObject.GetComponent<PlayerDamage>() != null)
        {
            other.gameObject.GetComponent<PlayerDamage>().GetDamage(damage);
        }
    }
    


    private Transform player; // Ссылка на объект игрока
    public float speed = 5f; // Скорость движения врага
    private float stoppingDistance = 6f; // Минимальное расстояние для остановки
    

    private Rigidbody2D rb; // Ссылка на Rigidbody2D врага

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Получаем компонент Rigidbody2D

        player = GameObject.Find("Player").transform;
    }

    void FixedUpdate()
    {
        // Вычисляем расстояние до игрока
        float distance = Vector2.Distance(transform.position, player.position);

        // Если враг находится дальше, чем stoppingDistance, движемся к игроку
        if (distance < stoppingDistance)
        {
            // Вычисляем направление к игроку
            Vector2 direction = (player.position - transform.position).normalized;

            // Двигаем врага в направлении игрока
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        }
    }

    public void Damage( float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}

