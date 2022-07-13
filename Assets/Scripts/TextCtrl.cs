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

    #region ���
    private string Stage1Text1 = "�� ���ڱ� ���� ? �ø����� ������ �ƹ��� �� �� �ִ� ���� �ƴ��ٵ�?";
    private string Stage1Text2 = "����� ����� �˱� ���� �Դ�. ���� ���� �ƴ� ���� �ִٸ� ���� ����!";
    private string Stage1Text3 = "��.... ���� ���ϸ� ���� ������ ������ �𸣰ھ�. \n �̹��� ���� ��� �����ְ� �ִµ�..��ũ���� ã���� ����������.";
    private string Stage1Text4 = "���� ���� ��� �������ε� ȥ�� �Ա⿡�� �Ʊ���� ���̾�..";
    private string Stage1Text5 = "���� ��п� ���� �˰� �ִ� �� �ִ°ǰ� ?";
    private string Stage1Text6 = "�ϴ� ���ö��~ õõ�� �̾߱� �����״�";
    private string Stage1Text7 = "���... �� ���� ? �ø����� ������ �ƹ��� �� �� �ִ� ���� �ƴ��ٵ�? \n �����淡 ���� ���� �Դ°���?";
    private string Stage1Text8 = "�����Ҹ��ϴ°ž�? �ݹ���� ��� �˷��شٰ� ���ݾ�";
    private string Stage1Text9 = "����� �� �����ʴ±�... �ʰ� �÷��� ����ߴٸ� �� �濡 ���ؼ� �� �˰ڱ�?  \n �� �Ը���� ���� ��ġ�� �� �ٲ��״� �ٲ� �κ��� ã�ƿ´ٸ� �Ͼ�����.";
    private string Stage1Text10 = "������ ����� ���� ���±�. \n ������ ���� ��Ҿ�..";
    private string Stage1Text11 = "������ ������ �־���?";
    private string Stage1Text12 = "���� �ǳ� �ǳ� ���� ������ �ϳ� �߳����� ���̶�� �ϴ���. \n �� �̻��� ���� �߸���. ���� ���̴��� �Ӹ��� ���� ���±�.";
    private string Stage1Text13 = "���ݸ� �� �ڼ��� ...";
    private string Stage2Text1 = "�ϵ���: ���� �پ��ִ� �ڴ� ���� ���ϴ� �� �̰Ŵ�.... ��� �°��� ?";
    private string Stage2Text2 = "�����: ���� ������ �̰��̿���.���� ����� ?";
    private string Stage2Text3 = "�ϵ���: �� ���� ���� �����ϴ� ���ļ����̴�.�ø��������� ���� ������?";
    private string Stage2Text4 = "�����: �� ������ ���� �˰� �ִ� ���� �ֳ�?";
    private string Stage2Text5 = "�ϵ���: ���� �� �˰�����.�ʳ� ������ ���ļ���� ��ü �� ���� ���´���....";
    private string Stage2Text6 = "�����: �װ� ���� ������?";
    private string Stage2Text7 = "�ϵ���: ���� ��� ���������� ������ �� ����.�ٸ� �� ���� ������ �ܼ��� �����Ŵ�.";
    private string Stage2Text8 = "�ϵ���: ���� ��� ���������� ������ �� ����.�ٸ� �� ���� ������ �ܼ��� �����Ŵ�. \n ��, ����ִ� �ڰ� �̰��� ������ �� ���ļ��迡 �տ��� ����Ŵ�. �ð��� �� ����.";
    private string Stage2Text9 = "�����:�տ� ��? �� ���� �������°ǰ�? �� ������ ������ ���ƺ��߰ھ�.";
    #endregion

    public bool OnDasa = false;

    public int clickCount = 0;

    

    

    private void Start()
    {
        TextCtrl.instance = this;
        
    }

    #region ��������1 ��� �ڷ�ƾ
    IEnumerator Stage1Txt1()
    {
        for (int i = 0; i <= Stage1Text1.Length; i++)
        {
            talkText.text = Stage1Text1.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 1��° ���
    IEnumerator Stage1Txt2()
    {
        for (int i = 0; i <= Stage1Text2.Length; i++)
        {
            talkText.text = Stage1Text2.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 2��° ���
    IEnumerator Stage1Txt3()
    {
        for (int i = 0; i <= Stage1Text3.Length; i++)
        {
            talkText.text = Stage1Text3.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 3��° ���
    IEnumerator Stage1Txt4()
    {
        for (int i = 0; i <= Stage1Text4.Length; i++)
        {
            talkText.text = Stage1Text4.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 4��° ���
    IEnumerator Stage1Txt5()
    {
        for (int i = 0; i <= Stage1Text5.Length; i++)
        {
            talkText.text = Stage1Text5.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 5��° ���
    IEnumerator Stage1Txt6()
    {
        for (int i = 0; i <= Stage1Text6.Length; i++)
        {
            talkText.text = Stage1Text6.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 6��° ���
    IEnumerator Stage1Txt7()
    {
        for (int i = 0; i <= Stage1Text7.Length; i++)
        {
            talkText.text = Stage1Text7.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 7��° ���
    IEnumerator Stage1Txt8()
    {
        for (int i = 0; i <= Stage1Text8.Length; i++)
        {
            talkText.text = Stage1Text8.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 8��° ���
    IEnumerator Stage1Txt9()
    {
        for (int i = 0; i <= Stage1Text9.Length; i++)
        {
            talkText.text = Stage1Text9.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 9��° ���
    IEnumerator Stage1Txt10()
    {
        for (int i = 0; i <= Stage1Text10.Length; i++)
        {
            talkText.text = Stage1Text10.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 10��° ���
    IEnumerator Stage1Txt11()
    {
        for (int i = 0; i <= Stage1Text11.Length; i++)
        {
            talkText.text = Stage1Text11.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 11��° ���
    IEnumerator Stage1Txt12()
    {
        for (int i = 0; i <= Stage1Text12.Length; i++)
        {
            talkText.text = Stage1Text12.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 12��° ���
    IEnumerator Stage1Txt13()
    {
        for (int i = 0; i <= Stage1Text13.Length; i++)
        {
            talkText.text = Stage1Text13.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������1�� 13��° ���
    #endregion
    #region ��������2 ��� �ڷ�ƾ
    IEnumerator Stage2Txt1()
    {
        for (int i = 0; i <= Stage2Text1.Length; i++)
        {
            talkText.text = Stage2Text1.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������2�� 1��° ���
    IEnumerator Stage2Txt2()
    {
        for (int i = 0; i <= Stage2Text2.Length; i++)
        {
            talkText.text = Stage2Text2.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������2�� 2��° ���
    IEnumerator Stage2Txt3()
    {
        for (int i = 0; i <= Stage2Text3.Length; i++)
        {
            talkText.text = Stage2Text3.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������2�� 3��° ���
    IEnumerator Stage2Txt4()
    {
        for (int i = 0; i <= Stage2Text4.Length; i++)
        {
            talkText.text = Stage2Text4.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������2�� 4��° ���
    IEnumerator Stage2Txt5()
    {
        for (int i = 0; i <= Stage2Text5.Length; i++)
        {
            talkText.text = Stage2Text5.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������2�� 5��° ���
    IEnumerator Stage2Txt6()
    {
        for (int i = 0; i <= Stage2Text6.Length; i++)
        {
            talkText.text = Stage2Text6.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������2�� 6��° ���
    IEnumerator Stage2Txt7()
    {
        for (int i = 0; i <= Stage2Text7.Length; i++)
        {
            talkText.text = Stage2Text7.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������2�� 7��° ���
    IEnumerator Stage2Txt8()
    {
        for (int i = 0; i <= Stage2Text8.Length; i++)
        {
            talkText.text = Stage2Text8.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������2�� 8��° ���
    IEnumerator Stage2Txt9()
    {
        for (int i = 0; i <= Stage2Text9.Length; i++)
        {
            talkText.text = Stage2Text9.Substring(0, i);
            yield return new WaitForSeconds(0.05f);
        }
        OnDasa = false;
    } // ��������2�� 9��° ���
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

    } // Ŭ�� �̺�Ʈ

    private void Stage1()
    {
        switch (clickCount)
        {
            case 1:
                introVideo.gameObject.SetActive(false);
                
                break;
            case 2:
                charText.text = "����ϼҽ�";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt1());
                talkText.fontSize = 20;
                Dionysus1.gameObject.SetActive(true);
                break;
            case 3:
                Dionysus1.gameObject.SetActive(false);
                charText.text = "�����";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt2());
                talkText.fontSize = 20;
                Bios1.gameObject.SetActive(true);
                break;
            case 4:
                Bios1.gameObject.SetActive(false);
                charText.text = "����ϼҽ�";
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
                charText.text = "����ϼҽ�";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt4());
                talkText.fontSize = 20;
                Dionysus3.gameObject.SetActive(true);
                break;
            case 7:
                Dionysus3.gameObject.SetActive(false);
                charText.text = "�����";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt5());
                talkText.fontSize = 20;
                Bios2.gameObject.SetActive(true);
                break;
            case 8:
                Bios2.gameObject.SetActive(false);
                charText.text = "����ϼҽ�";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt6());
                talkText.fontSize = 20;
                Dionysus4.gameObject.SetActive(true);
                break;
            case 9:
                Dionysus4.gameObject.SetActive(false);
                charText.text = "����ϼҽ�";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt7());
                talkText.fontSize = 20;
                Dionysus5.gameObject.SetActive(true);
                break;
            case 10:
                Dionysus5.gameObject.SetActive(false);
                charText.text = "�����";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt8());
                talkText.fontSize = 20;
                Bios3.gameObject.SetActive(true);
                break;
            case 11:
                Bios3.gameObject.SetActive(false);
                charText.text = "����ϼҽ�";
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
                charText.text = "����ϼҽ�";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt10());
                talkText.fontSize = 20;
                Dionysus2.gameObject.SetActive(true);
                break;
            case 14:
                Dionysus2.gameObject.SetActive(false);
                charText.text = "�����";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt11());
                talkText.fontSize = 20;
                Bios3.gameObject.SetActive(true);
                break;
            case 15:
                Bios3.gameObject.SetActive(false);
                charText.text = "����ϼҽ�";
                charText.fontSize = 40;
                StartCoroutine(Stage1Txt12());
                talkText.fontSize = 20;
                Dionysus4.gameObject.SetActive(true);
                break;
            case 16:
                Dionysus4.gameObject.SetActive(false);
                charText.text = "�����";
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
    } // ��������1

    private void Stage2()
    {
        switch (clickCount)
        {
            case 19:
                charText.text = "�ϵ���";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt1());
                talkText.fontSize = 20;
                break;
            case 20:
                charText.text = "�����";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt2());
                talkText.fontSize = 20;
                break;
            case 21:
                charText.text = "�ϵ���";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt3());
                talkText.fontSize = 20;
                break;
            case 22:
                charText.text = "�����";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt4());
                talkText.fontSize = 20;
                break;
            case 23:
                charText.text = "�ϵ���";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt5());
                talkText.fontSize = 20;
                break;
            case 24:
                charText.text = "�����";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt6());
                talkText.fontSize = 20;
                break;
            case 25:
                charText.text = "�ϵ���";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt7());
                talkText.fontSize = 20;
                break;
            case 26:
                charText.text = "�ϵ���";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt8());
                talkText.fontSize = 20;
                break;
            case 27:
                charText.text = "�ϵ���";
                charText.fontSize = 40;
                StartCoroutine(Stage2Txt9());
                talkText.fontSize = 20;
                break;
            case 28:
                SceneManager.LoadScene("Ending");
                break;
        }
    } // ��������2

    private void Update()
    {
        ClickEvent();
    }
    
    
}