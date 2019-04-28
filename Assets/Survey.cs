using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Survey : MonoBehaviour {

    public Transform fin;
    public Transform a;
    public Transform b;
    public Transform c;
    public Transform d;
    public Transform title;

    private string[][] q;
    public string[] q1;
    public string[] q2;
    public string[] q3;
    public string[] q4;
    public string[] q5;

    public string[] t1;
    public string[] t2;
    public string[] t3;
    public string[] t4;
    public string[] t5;
    private int index = 0;
    // Update is called once per frame
    void Start () {
        if (Singleton.Instance.SurveyType() == 1)
        {
            q = new string[][] { q1, q2, q3, q5, q4 };
        }
        else
        {
            q = new string[][] { t1, t2, t3, t4, t5 };
        }

        a = this.transform.Find("Panel/A");
        b = this.transform.Find("Panel/B");
        c = this.transform.Find("Panel/C");
        d = this.transform.Find("Panel/D");
        title = this.transform.Find("Panel/Question");
        /*
        Instantiate(a);
        Instantiate(b);
        Instantiate(c);
        Instantiate(d);
        Instantiate(title);*/

        UpdateText(q[index]);
    }

    void Build(string[] text)
    {
        Instantiate(a).GetComponentInChildren<Text>().text = text[0];
        Instantiate(b).GetComponentInChildren<Text>().text = text[1];
        Instantiate(c).GetComponentInChildren<Text>().text = text[2];
        Instantiate(d).GetComponentInChildren<Text>().text = text[3];
        Instantiate(title).GetComponent<TextMeshProUGUI>().text = text[4];
    }

    void UpdateText(string[] text)
    {
        a.GetComponentInChildren<Text>().text = text[0];
        b.GetComponentInChildren<Text>().text = text[1];
        c.GetComponentInChildren<Text>().text = text[2];
        d.GetComponentInChildren<Text>().text = text[3];
        title.GetComponent<TextMeshProUGUI>().text = text[4];
    }

    public void Next()
    {
        index++;
        if (index < 5) { 
            UpdateText(q[index]);
        }
        else
        {
            fin.transform.localPosition = Vector3.zero;
        }
    }
}
