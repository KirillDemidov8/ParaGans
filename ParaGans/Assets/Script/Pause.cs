using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject panelPause;


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            panelPause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Contine()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1;
    }
}
