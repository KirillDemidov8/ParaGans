
using UnityEngine;

public class TakeGun : MonoBehaviour
{
   private bool canTake = false;

    [SerializeField] private Shoot shoot;
    
    

    public string nameGan;

    private void Update()
    {
        
        if (canTake && Input.GetKeyDown("space"))
        {

            ChageGun();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.GetComponent<PlayerMove>() != null)
        {
            Debug.Log("Игрок");
            canTake = true;
        }
    }

    private void ChageGun()
    {
        shoot.ChageGun(nameGan);
        PlauerParametrs.instance.TakeGun();
    }

    
}
