using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TypingEffect : MonoBehaviour
{
    public TextMeshProUGUI txtTitle_1;
    public TextMeshProUGUI txtTitle_2;
    public TextMeshProUGUI txtTitle_3;
    public TextMeshProUGUI txtTitle_4;
    public TextMeshProUGUI txtTitle_5;
    public TextMeshProUGUI txtTitle_6;
    public TextMeshProUGUI txtTitle_7;
    public TextMeshProUGUI txtTitle_8;
    public TextMeshProUGUI txtTitle_9;
    public Text txtTitle_10;
    private string m_text1 = "윽... 뭔가 부딛친것 같은데";
    private string m_text2 = "뭐지.. 이 칠흙같은 어두움은;";
    private string m_text3 = "나 죽은 건가?..";
    private string m_text4 = "안돼... 난 게임 개발자가 되야 해.";
    private string m_text5 = "이대로 죽을 순 없어!";
    private string m_text6 = "정말 게임 개발자가 되고 싶은가요?";
    private string m_text7 = "네?.. 누구세요??!!";
    private string m_text8 = "정말 게임 개발자가 되고 싶은지 물었습니다.";
    private string m_text9 = "되고 싶어요!!";
    private string m_text10 = "그러면 게임이 되어보세요.";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing1(txtTitle_1, txtTitle_2, txtTitle_3, txtTitle_4, txtTitle_5, txtTitle_6, txtTitle_7, txtTitle_8, txtTitle_9, txtTitle_10));
    }

    IEnumerator _typing1(TextMeshProUGUI t1, TextMeshProUGUI t2, TextMeshProUGUI t3, TextMeshProUGUI t4, TextMeshProUGUI t5, TextMeshProUGUI t6, TextMeshProUGUI t7, TextMeshProUGUI t8, TextMeshProUGUI t9, Text t10)
    {
        t1.color = new Color(t1.color.r, t1.color.g, t1.color.b, 0);
        t2.color = new Color(t2.color.r, t2.color.g, t2.color.b, 0);
        t3.color = new Color(t3.color.r, t3.color.g, t3.color.b, 0);
        t4.color = new Color(t4.color.r, t4.color.g, t4.color.b, 0);
        t5.color = new Color(t5.color.r, t5.color.g, t5.color.b, 0);
        t6.color = new Color(t6.color.r, t6.color.g, t6.color.b, 0);
        t7.color = new Color(t7.color.r, t7.color.g, t7.color.b, 0);
        t8.color = new Color(t8.color.r, t8.color.g, t8.color.b, 0);
        t9.color = new Color(t9.color.r, t9.color.g, t9.color.b, 0);
        t10.color = new Color(t10.color.r, t10.color.g, t10.color.b, 0);


        yield return new WaitForSeconds(7f);
        
        // 주인공 ment 보여지기 
        for (int i = 0; i <= m_text1.Length; i++)
        {
            t1.color = new Color(t1.color.r, t1.color.g, t1.color.b, 1);
            txtTitle_1.text = m_text1.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }

        for (int i = 0; i <= m_text2.Length; i++)
        {
            t2.color = new Color(t2.color.r, t2.color.g, t2.color.b, 1);
            txtTitle_2.text = m_text2.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }

        for (int i = 0; i <= m_text3.Length; i++)
        {
            t3.color = new Color(t3.color.r, t3.color.g, t3.color.b, 1);
            txtTitle_3.text = m_text3.Substring(0, i);

            yield return new WaitForSeconds(0.20f);
        }

        for (int i = 0; i <= m_text4.Length; i++)
        {
            t4.color = new Color(t4.color.r, t4.color.g, t4.color.b, 1);
            txtTitle_4.text = m_text4.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }

        for (int i = 0; i <= m_text5.Length; i++)
        {
            t5.color = new Color(t5.color.r, t5.color.g, t5.color.b, 1);
            txtTitle_5.text = m_text5.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }

        while (t1.color.a > 0.0f || t2.color.a > 0.0f || t3.color.a > 0.0f || t4.color.a > 0.0f || t5.color.a > 0.0f)
        {
            t1.color = new Color(t1.color.r, t1.color.g, t1.color.b, t1.color.a - (Time.deltaTime / 0.50f));
            t2.color = new Color(t2.color.r, t2.color.g, t2.color.b, t2.color.a - (Time.deltaTime / 0.50f));
            t3.color = new Color(t3.color.r, t3.color.g, t3.color.b, t3.color.a - (Time.deltaTime / 0.50f));
            t4.color = new Color(t4.color.r, t4.color.g, t4.color.b, t4.color.a - (Time.deltaTime / 0.50f));
            t5.color = new Color(t5.color.r, t5.color.g, t5.color.b, t5.color.a - (Time.deltaTime / 0.50f));
            yield return null;
        }

        // 알수없는 누군가와 대화

        yield return new WaitForSeconds(2f);

        for (int i = 0; i <= m_text6.Length; i++)
        {
            t6.color = new Color(t6.color.r, t6.color.g, t6.color.b, 1);
            txtTitle_6.text = m_text6.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }

        for (int i = 0; i <= m_text7.Length; i++)
        {
            t7.color = new Color(t7.color.r, t7.color.g, t7.color.b, 1);
            txtTitle_7.text = m_text7.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }

        for (int i = 0; i <= m_text8.Length; i++)
        {
            t8.color = new Color(t8.color.r, t8.color.g, t8.color.b, 1);
            txtTitle_8.text = m_text8.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }

        for (int i = 0; i <= m_text9.Length; i++)
        {
            t9.color = new Color(t9.color.r, t9.color.g, t9.color.b, 1);
            txtTitle_9.text = m_text9.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }

        while (t6.color.a > 0.0f || t7.color.a > 0.0f || t8.color.a > 0.0f || t9.color.a > 0.0f)
        {
            t6.color = new Color(t6.color.r, t6.color.g, t6.color.b, t6.color.a - (Time.deltaTime / 0.35f));
            t7.color = new Color(t7.color.r, t7.color.g, t7.color.b, t7.color.a - (Time.deltaTime / 0.35f));
            t8.color = new Color(t8.color.r, t8.color.g, t8.color.b, t8.color.a - (Time.deltaTime / 0.35f));
            t9.color = new Color(t9.color.r, t9.color.g, t9.color.b, t9.color.a - (Time.deltaTime / 0.35f));
            yield return null;
        }

        for (int i = 0; i <= m_text10.Length; i++)
        {
            t10.color = new Color(t10.color.r, t10.color.g, t10.color.b, 1);
            txtTitle_10.text = m_text10.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }

        while (t10.color.a > 0.0f)
        {
            t10.color = new Color(t10.color.r, t10.color.g, t10.color.b, t10.color.a - (Time.deltaTime / 1.5f));
            yield return null;
        }

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
