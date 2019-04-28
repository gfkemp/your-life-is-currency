using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurveyController : MonoBehaviour {

    public Transform fin;
    public Transform ad;
    public Transform survey;

    private Singleton singleton;

    private string mode;
    [SerializeField]
    private float timer = 0;

    private void Awake()
    {
        singleton = Singleton.Instance;
        if (singleton.SurveyType() == 3)
        {
            mode = "AD";
            ad.localPosition = Vector3.zero;
            ad.GetComponentInChildren<UnityEngine.Video.VideoPlayer>().enabled = true;
            timer = 100f;
        }
        else
        {
            mode = "SURVEY";
            survey.localPosition = Vector3.zero;
        }

        singleton.IncSurveyType();
    }

    // Update is called once per frame
    void Update () {
		if (mode.Equals("AD"))
        {
            UpdateAd();
        }
        else if (mode.Equals("SURVEY"))
        {
            //UpdateSurvey();
        }
        else if (mode.Equals("FIN"))
        {

        }
	}

    private void UpdateSurvey()
    {
        throw new NotImplementedException();
    }

    private void UpdateAd()
    {
        if (timer > 0)
        {
            timer -= 0.1f;
        }
        else
        {
            mode = "FIN";
            ad.GetComponentInChildren<UnityEngine.Video.VideoPlayer>().Pause();
            fin.localPosition = Vector3.zero;
        }
    }

    public void BackToMenu()
    {
        singleton.AddKempBucks(1.5f);
        singleton.Load("MainMenu");
    }
}
