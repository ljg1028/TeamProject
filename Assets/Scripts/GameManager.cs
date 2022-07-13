using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitBtn()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
    public void SaveBtn()
    {
        SaveData character = new SaveData(0, transform.position);

        SaveSystem.Save(character, "save_001");
    }

    public void LoadBtn()
    {
        SaveData loadData = SaveSystem.Load("save_001");
        TextCtrl.instance.clickCount = loadData.clickCount;
        Player.instance.gameObject.transform.position = loadData.player;
    }
}