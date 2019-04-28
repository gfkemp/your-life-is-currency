using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour {

    private static Singleton _instance;
    public float kempBucks = 2.5f;
    private int surveyType = 1;

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<Singleton>();
            }

            return _instance;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Load (string scene)
    {
        SceneManager.LoadScene(scene);
    }

    internal int SurveyType()
    {
        return surveyType;
    }

    internal void IncSurveyType()
    {
        surveyType %= 2;
        surveyType++;
    }

    public float GetKempBucks()
    {
        return kempBucks;
    }

    public void AddKempBucks(float inc)
    {
        kempBucks += inc;
    }
}
