using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextCtrl : MonoBehaviour
{
    public static TextCtrl instance;
    public GameObject Background;
    [SerializeField] private GameObject talkPanel;
    [SerializeField] private GameObject oakCask;
    [SerializeField] private GameObject introVideo;
    [SerializeField] private GameObject stageVideo;
    public Image talkTap;
    [SerializeField] private Image Dionysus1;
    [SerializeField] private Image Dionysus2;
    [SerializeField] private Image Dionysus3;
    [SerializeField] private Image Dionysus4;
    [SerializeField] private Image Dionysus5;
    [SerializeField] private Image Bios1;
    [SerializeField] private Image Bios2;
    [SerializeField] private Image Bios3;
    [SerializeField] private Text charText;
    [SerializeField] private Text talkText;
    [SerializeField] private Text TimeOutText;

    #region 대사
    private string Stage1Text1 = "넌 갑자기 뭐야 ? 올림포스 신전은 아무나 올 수 있는 곳이 아닐텐데?";
    private string Stage1Text2 = "출생의 비밀을 알기 위해 왔다. 나에 대해 아는 것이 있다면 당장 말해!";
    private string Stage1Text3 = "흠.... 술에 취하면 뭔가 생각이 날지도 모르겠어. \n 이번에 직접 담근 포도주가 있는데..오크통을 찾으면 대접해주지.";
    private string Stage1Text4 = "내가 직접 담근 포도주인데 혼자 먹기에는 아까워서 말이야..";
    private string Stage1Text5 = "나의 비밀에 대해 알고 있는 게 있는건가 ?";
    private string Stage1Text6 = "일단 마시라고~ 천천히 이야기 해줄테니";
    private string Stage1Text7 = "잠깐만... 넌 뭐야 ? 올림포스 신전은 아무나 올 수 있는 곳이 아닐텐데? \n 누구길래 나랑 술을 먹는거지?";
    private string Stage1Text8 = "무슨소리하는거야? 금방까지 비밀 알려준다고 했잖아";
    private string Stage1Text9 = "기억이 잘 나지않는군... 너가 시련을 통과했다면 내 방에 대해서 잘 알겠군?  \n 내 입맛대로 물건 위치를 좀 바꿀테니 바뀐 부분을 찾아온다면 믿어주지.";
    private string Stage1Text10 = "이제야 기억이 조금 나는군. \n 누나랑 많이 닮았어..";
    private string Stage1Text11 = "나에게 누나가 있었나?";
    private string Stage1Text12 = "나도 건너 건너 들은 거지만 꽤나 잘나가는 신이라고 하더군. \n 그 이상은 나도 잘몰라. 술을 마셨더니 머리가 빙빙 도는군.";
    private string Stage1Text13 = "조금만 더 자세ㅎ ...";
    private string Stage2Text1 = "하데스: 숨이 붙어있는 자는 오지 못하는 곳 이거늘.... 어떻게 온거지 ?";
    private string Stage2Text2 = "비오스: 눈을 떠보니 이곳이였어.여긴 어디지 ?";
    private string Stage2Text3 = "하데스: 이 곳은 내가 관리하는 사후세계이다.올림포스에는 무슨 일이지?";
    private string Stage2Text4 = "비오스: 내 누나에 대해 알고 있는 것이 있나?";
    private string Stage2Text5 = "하데스: 아주 잘 알고있지.너네 누나가 사후세계로 대체 몇 명을 보냈는지....";
    private string Stage2Text6 = "비오스: 그게 무슨 말이지?";
    private string Stage2Text7 = "하데스: 신은 운명에 직접적으로 관여할 수 없다.다만 이 세계 곳곳에 단서가 있을거다.";
    private string Stage2Text8 = "하데스: 신은 운명에 직접적으로 관여할 수 없다.다만 이 세계 곳곳에 단서가 있을거다. \n 단, 살아있는 자가 이곳에 있으니 곧 사후세계에 균열이 생길거다. 시간이 얼마 없어.";
    private string Stage2Text9 = "비오스:균열 …? 이 곳이 무너지는건가? 맵 곳곳을 빠르게 돌아봐야겠어.";
    #endregion

    public bool OnDasa = false;

    public int clickCount = 0;

    

    

    private void Start()
    {
        TextCtrl.instance = this;
        
    }

    #region 스테이지1 대사 코루틴
    IEnumerator Stage1Txt1()
    {
        for (int i = 0; i <= Stage1Text1.Length; i++)
        {
            talkText.text = Stage1Text1.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 1번째 대사
    IEnumerator Stage1Txt2()
    {
        for (int i = 0; i <= Stage1Text2.Length; i++)
        {
            talkText.text = Stage1Text2.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 2번째 대사
    IEnumerator Stage1Txt3()
    {
        for (int i = 0; i <= Stage1Text3.Length; i++)
        {
            talkText.text = Stage1Text3.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 3번째 대사
    IEnumerator Stage1Txt4()
    {
        for (int i = 0; i <= Stage1Text4.Length; i++)
        {
            talkText.text = Stage1Text4.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 4번째 대사
    IEnumerator Stage1Txt5()
    {
        for (int i = 0; i <= Stage1Text5.Length; i++)
        {
            talkText.text = Stage1Text5.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 5번째 대사
    IEnumerator Stage1Txt6()
    {
        for (int i = 0; i <= Stage1Text6.Length; i++)
        {
            talkText.text = Stage1Text6.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 6번째 대사
    IEnumerator Stage1Txt7()
    {
        for (int i = 0; i <= Stage1Text7.Length; i++)
        {
            talkText.text = Stage1Text7.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 7번째 대사
    IEnumerator Stage1Txt8()
    {
        for (int i = 0; i <= Stage1Text8.Length; i++)
        {
            talkText.text = Stage1Text8.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 8번째 대사
    IEnumerator Stage1Txt9()
    {
        for (int i = 0; i <= Stage1Text9.Length; i++)
        {
            talkText.text = Stage1Text9.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 9번째 대사
    IEnumerator Stage1Txt10()
    {
        for (int i = 0; i <= Stage1Text10.Length; i++)
        {
            talkText.text = Stage1Text10.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 10번째 대사
    IEnumerator Stage1Txt11()
    {
        for (int i = 0; i <= Stage1Text11.Length; i++)
        {
            talkText.text = Stage1Text11.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 11번째 대사
    IEnumerator Stage1Txt12()
    {
        for (int i = 0; i <= Stage1Text12.Length; i++)
        {
            talkText.text = Stage1Text12.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 12번째 대사
    IEnumerator Stage1Txt13()
    {
        for (int i = 0; i <= Stage1Text13.Length; i++)
        {
            talkText.text = Stage1Text13.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지1의 13번째 대사
    #endregion
    #region 스테이지2 대사 코루틴
    IEnumerator Stage2Txt1()
    {
        for (int i = 0; i <= Stage2Text1.Length; i++)
        {
            talkText.text = Stage2Text1.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지2의 1번째 대사
    IEnumerator Stage2Txt2()
    {
        for (int i = 0; i <= Stage2Text2.Length; i++)
        {
            talkText.text = Stage2Text2.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지2의 2번째 대사
    IEnumerator Stage2Txt3()
    {
        for (int i = 0; i <= Stage2Text3.Length; i++)
        {
            talkText.text = Stage2Text3.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지2의 3번째 대사
    IEnumerator Stage2Txt4()
    {
        for (int i = 0; i <= Stage2Text4.Length; i++)
        {
            talkText.text = Stage2Text4.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지2의 4번째 대사
    IEnumerator Stage2Txt5()
    {
        for (int i = 0; i <= Stage2Text5.Length; i++)
        {
            talkText.text = Stage2Text5.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지2의 5번째 대사
    IEnumerator Stage2Txt6()
    {
        for (int i = 0; i <= Stage2Text6.Length; i++)
        {
            talkText.text = Stage2Text6.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지2의 6번째 대사
    IEnumerator Stage2Txt7()
    {
        for (int i = 0; i <= Stage2Text7.Length; i++)
        {
            talkText.text = Stage2Text7.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지2의 7번째 대사
    IEnumerator Stage2Txt8()
    {
        for (int i = 0; i <= Stage2Text8.Length; i++)
        {
            talkText.text = Stage2Text8.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지2의 8번째 대사
    IEnumerator Stage2Txt9()
    {
        for (int i = 0; i <= Stage2Text9.Length; i++)
        {
            talkText.text = Stage2Text9.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // 스테이지2의 9번째 대사
    #endregion

    private void ClickEvent()
    {
        if (Input.GetMouseButtonDown(0) && OnDasa == false)
        {
            if (talkTap.gameObject.activeSelf == true)
            {
                clickCount += 1;
            }
            Stage1();
            Stage2();
            if (clickCount == 1 || clickCount == 5 || clickCount == 12 || clickCount == 17 || clickCount == 18)
            {
                OnDasa = false;
            }
            else
            {
                OnDasa = true;
            }
        }

        if (Input.GetMouseButtonDown(1) && OnDasa == true)
        {
            StopAllCoroutines();
            OnDasa = false;
            if (clickCount == 2)
            {
                talkText.text = Stage1Text1;
            }
            else if (clickCount == 3)
            {
                talkText.text = Stage1Text2;
            }
            else if (clickCount == 4)
            {
                talkText.text = Stage1Text3;
            }
            else if (clickCount == 6)
            {
                talkText.text = Stage1Text4;
            }
            else if (clickCount == 7)
            {
                talkText.text = Stage1Text5;
            }
            else if (clickCount == 8)
            {
                talkText.text = Stage1Text6;
            }
            else if (clickCount == 9)
            {
                talkText.text = Stage1Text7;
            }
            else if (clickCount == 10)
            {
                talkText.text = Stage1Text8;
            }
            else if (clickCount == 11)
            {
                talkText.text = Stage1Text9;
            }
            else if (clickCount == 13)
            {
                talkText.text = Stage1Text10;
            }
            else if (clickCount == 14)
            {
                talkText.text = Stage1Text11;
            }
            else if (clickCount == 15)
            {
                talkText.text = Stage1Text12;
            }
            else if (clickCount == 16)
            {
                talkText.text = Stage1Text13;
            }
            else if (clickCount == 19)
            {
                talkText.text = Stage2Text1;
            }
            else if (clickCount == 20)
            {
                talkText.text = Stage2Text2;
            }
            else if (clickCount == 21)
            {
                talkText.text = Stage2Text3;
            }
            else if (clickCount == 22)
            {
                talkText.text = Stage2Text4;
            }
            else if (clickCount == 23)
            {
                talkText.text = Stage2Text5;
            }
            else if (clickCount == 24)
            {
                talkText.text = Stage2Text6;
            }
            else if (clickCount == 25)
            {
                talkText.text = Stage2Text7;
            }
            else if (clickCount == 26)
            {
                talkText.text = Stage2Text8;
            }
            else if (clickCount == 27)
            {
                talkText.text = Stage2Text9;
            }
        }

    } // 클릭 이벤트

    private void Stage1()
    {
        switch (clickCount)
        {
            case 1:
                introVideo.gameObject.SetActive(false);
                
                break;
            case 2:
                charText.text = "디오니소스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt1());
                talkText.fontSize = 20;
                Dionysus1.gameObject.SetActive(true);
                break;
            case 3:
                Dionysus1.gameObject.SetActive(false);
                charText.text = "비오스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt2());
                talkText.fontSize = 20;
                Bios1.gameObject.SetActive(true);
                break;
            case 4:
                Bios1.gameObject.SetActive(false);
                charText.text = "디오니소스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt3());
                talkText.fontSize = 20;
                Dionysus2.gameObject.SetActive(true);
                break;
            case 5:
                oakCask.SetActive(true);
                Player.instance.playerMove = true;
                TimeAttack.instace.TimeOut = true;
                charText.text = "";
                talkText.text = "";
                talkTap.gameObject.SetActive(false);
                Dionysus2.gameObject.SetActive(false);
                Background.gameObject.SetActive(false);
                break;
            case 6:
                charText.text = "디오니소스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt4());
                talkText.fontSize = 20;
                Dionysus3.gameObject.SetActive(true);
                break;
            case 7:
                Dionysus3.gameObject.SetActive(false);
                charText.text = "비오스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt5());
                talkText.fontSize = 20;
                Bios2.gameObject.SetActive(true);
                break;
            case 8:
                Bios2.gameObject.SetActive(false);
                charText.text = "디오니소스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt6());
                talkText.fontSize = 20;
                Dionysus4.gameObject.SetActive(true);
                break;
            case 9:
                Dionysus4.gameObject.SetActive(false);
                charText.text = "디오니소스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt7());
                talkText.fontSize = 20;
                Dionysus5.gameObject.SetActive(true);
                break;
            case 10:
                Dionysus5.gameObject.SetActive(false);
                charText.text = "비오스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt8());
                talkText.fontSize = 20;
                Bios3.gameObject.SetActive(true);
                break;
            case 11:
                Bios3.gameObject.SetActive(false);
                charText.text = "디오니소스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt9());
                talkText.fontSize = 20;
                Dionysus1.gameObject.SetActive(true);
                break;
            case 12:
                charText.text = "";
                talkText.text = "";
                gameObject.SetActive(false);
                Player.instance.FindWrong1 = true;
                Dionysus1.gameObject.SetActive(false);
                Background.gameObject.SetActive(false);
                break;
            case 13:
                charText.text = "디오니소스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt10());
                talkText.fontSize = 20;
                Dionysus2.gameObject.SetActive(true);
                break;
            case 14:
                Dionysus2.gameObject.SetActive(false);
                charText.text = "비오스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt11());
                talkText.fontSize = 20;
                Bios3.gameObject.SetActive(true);
                break;
            case 15:
                Bios3.gameObject.SetActive(false);
                charText.text = "디오니소스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt12());
                talkText.fontSize = 20;
                Dionysus4.gameObject.SetActive(true);
                break;
            case 16:
                Dionysus4.gameObject.SetActive(false);
                charText.text = "비오스";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt13());
                talkText.fontSize = 20;
                Bios2.gameObject.SetActive(true);
                break;
            case 17:
                Bios2.gameObject.SetActive(false);
                stageVideo.gameObject.SetActive(true);
                break;
            case 18:
                stageVideo.gameObject.SetActive(false);
                charText.text = "";
                talkText.text = "";
                break;
        }
    } // 스테이지1

    private void Stage2()
    {
        switch (clickCount)
        {
            case 19:
                charText.text = "하데스";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt1());
                talkText.fontSize = 20;
                break;
            case 20:
                charText.text = "비오스";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt2());
                talkText.fontSize = 20;
                break;
            case 21:
                charText.text = "하데스";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt3());
                talkText.fontSize = 20;
                break;
            case 22:
                charText.text = "비오스";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt4());
                talkText.fontSize = 20;
                break;
            case 23:
                charText.text = "하데스";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt5());
                talkText.fontSize = 20;
                break;
            case 24:
                charText.text = "비오스";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt6());
                talkText.fontSize = 20;
                break;
            case 25:
                charText.text = "하데스";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt7());
                talkText.fontSize = 20;
                break;
            case 26:
                charText.text = "하데스";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt8());
                talkText.fontSize = 20;
                break;
            case 27:
                charText.text = "하데스";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt9());
                talkText.fontSize = 20;
                break;
            case 28:
                SceneManager.LoadScene("Ending");
                break;
        }
    } // 스테이지2

    private void Update()
    {
        ClickEvent();
    }
    
    
}