using Unity.VisualScripting;
using UnityEngine;

public class BollrtFlly : MonoBehaviour
{
    private Gan gan;

    private float breakNow = 0;

    private Vector3 direction; // Ќаправление полета пули

    private void Start()
    {
        Destroy(gameObject, gan.Time);
    }



    // ћетод дл€ запуска пули с заданным направлением
    public void Launch(Vector2 launchDirection, Gan gun)
    {
        gan = gun;
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(gan.nameGun);
        direction = launchDirection.normalized; // Ќормализуем и сохран€ем направление
    }

    void Update()
    {
        // ѕеремещаем пулю в заданном направлении
        transform.Translate(direction * gan.Speed* Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // «десь можно добавить логику, что происходит при столкновении
        // Ќапример, уничтожить пулю
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
        if (other.GetComponent<Enamy>() != null)
        {
            other.GetComponent<Enamy>().Damage(gan.Damage);
            breakNow++;
            if (breakNow == gan.Breaking)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
