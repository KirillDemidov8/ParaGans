using System.Collections.Generic;
using UnityEngine;

public class DictionaryGun : MonoBehaviour
{
    public static Dictionary<string, Gan> DicGun()
    {
        Dictionary<string, Gan> dic = new Dictionary<string, Gan>();
        dic.Add("startGun", new Gan{ nameGun = "startGun", Breaking = 1, Damage = 5, Speed = 2, Time = 2 });
        dic.Add("shiptGun", new Gan{ nameGun = "shiptGun", Breaking = 2, Damage = 10, Speed = 2, Time = 2 });
        dic.Add("coolGun", new Gan{ nameGun = "coolGun", Breaking = 3, Damage = 30, Speed = 5, Time = 3 });
        return dic;
    }

    private Dictionary<string, Gan> dictionaryGun = DicGun();

    public Gan GetGun(string name)
    {
        return dictionaryGun[name];
    }
}
