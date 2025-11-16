using UnityEngine;
using UnityEngine.UI;

public class PlauerParametrs : MonoBehaviour
{
    [SerializeField] private Slider sliderHp;
    [SerializeField] private Slider sliderStym;
    [SerializeField] private GameObject gun;



    private int stok = 100;

    private int stym = 100;

    public int Stok { get { return stok; } set { stok = value; } }

    public int Stym { get { return stym; } set { stym = value; } }
    private float hp = 100;

    public static PlauerParametrs instance;
    private void Awake()
    {
        instance = this;
        sliderStym.maxValue = Stym;
        sliderStym.value = Stym;
    }

    public void GetDamage(float damage )
    {
        hp -= damage;
        Debug.Log(hp);
        sliderHp.value = hp;
    }
    public void TakeGun()
    {
        gun.SetActive(true);
    }
    public void ShowStok()
    {
        Debug.Log(Stok);
    }
    public void ShowStim()
    {
        
        sliderStym.value = stym;
    }
}
