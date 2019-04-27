using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIController : MonoBehaviour {

    public WheelCollider bl;
    public WheelCollider br;
    public TextMeshProUGUI rpmDisplay;

    private void Update()
    {
        float rpm = Mathf.Abs((bl.rpm + br.rpm) / 2);
        rpmDisplay.text = "RPM: " + rpm;
    }
}
