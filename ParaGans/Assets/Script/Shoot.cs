using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject targetPrefab;

    [SerializeField] private DictionaryGun dictionaryGun;

    private int mag;
    private int maxMag = 5;


    
   
    private GanMove ganMove;
    private Gan gan;

    private string nameGun = "startGun";

    private void Start()
    {
        mag = maxMag;
        ganMove = GetComponent<GanMove>();
        GetGun();
        

    }
    void Update()
    {
        // ��������� ������� ������ ���� (����� ������)
        if (Input.GetMouseButtonDown(0))
        {
            if (IsCountPatrons())
            {
                Shooting();
                ShotGunStim();
                mag--;
            }
            else
            {
                ReloadGun();
            }
        }
    }

    public void ReloadGun()
    {
        PlauerParametrs.instance.Stok -= maxMag;
        mag = maxMag;
        PlauerParametrs.instance.ShowStok();
    }

    public void ShotGunStim()
    {
        PlauerParametrs.instance.Stym -= 10;
     
        PlauerParametrs.instance.ShowStim();
    }

    public void GetGun()
    {
        gan = dictionaryGun.GetGun(nameGun);
    }
    public void ChageGun(string name)
    {
        nameGun = name;
        GetGun();
    }
    
    private bool IsCountPatrons()
    {
        return mag > 0;
        
    }

    void Shooting()
    {
        // ������� ���� � ������� �������, � �������� ���������� ������
        GameObject bullet = Instantiate(bulletPrefab, targetPrefab.transform.position,Quaternion.identity);

        
        bullet.GetComponent<BollrtFlly>().Launch(ganMove.GetDirection(), gan);

        

    }

    public void ChangeGun(string name)
    {
        nameGun = name;
        GetGun();
    }
}
