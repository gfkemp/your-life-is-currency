using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

    private Singleton singleton;
    public TextMeshProUGUI money;
    public Button playButton;

    private void Awake()
    {
        singleton = Singleton.Instance;
    }

    public void PlayGameButton()
    {
        singleton.AddKempBucks(-2f);
        singleton.Load("Drive");
    }

    public void SurveyButton()
    {
        singleton.Load("Survey");
    }

    private void Update()
    {
        float cash = singleton.GetKempBucks();
        money.text = cash + " KempBucks";

        if (cash < 2)
        {
            playButton.interactable = false;
        } else
        {
            playButton.interactable = true;
        }
    }
}
