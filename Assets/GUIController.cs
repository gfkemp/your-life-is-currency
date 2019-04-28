using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIController : MonoBehaviour {

    public TextMeshProUGUI money;
    public Car car;
    public Transform guiPanel;
    [SerializeField]
    private float time = 50;

    private Singleton singleton;
    bool update = true;

    private void Awake()
    {
        this.singleton = Singleton.Instance;
    }

    private void Update()
    {
        if (time > 0)
        {
            time -= 0.1f;
        }
        else if (update)
        {
            //GAME OVER
            update = false;
            car.Stop();
            Debug.Log("stop");
            guiPanel.localPosition = Vector3.zero;

            float cash = (float)System.Math.Round(Random.Range(0.01f, 0.99f), 3);
            money.text = "you earned " + cash + " KempBucks!";
            singleton.AddKempBucks(cash);
        }
    }

    public void ToMenuButton()
    {
        singleton.Load("MainMenu");
    }
}
