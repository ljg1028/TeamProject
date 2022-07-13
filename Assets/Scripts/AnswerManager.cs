using UnityEngine;
using UnityEngine.UI;


public class AnswerManager : MonoBehaviour
{
    [SerializeField] private GameObject Clicker;
    [SerializeField] private GameObject door;
    [SerializeField] private string Answer;

    public void ansewr(InputField ip)
    {
        if (ip.text == Answer)
        {
            TextCtrl.instance.talkTap.gameObject.SetActive(true);
            TextCtrl.instance.OnDasa = false;
            gameObject.SetActive(false);
            TextCtrl.instance.Background.SetActive(true);
            Clicker.SetActive(false);
            door.SetActive(false);
            Player.instance.playerMove = false;
        }
        else
        {
            Debug.Log("오답입니다");
        }
    }
}