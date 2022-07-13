using UnityEngine;

public class SaveTap : MonoBehaviour
{
    public GameObject save;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (save.activeSelf == true)
                save.SetActive(false);
            else
                save.SetActive(true);
        }
    }
}