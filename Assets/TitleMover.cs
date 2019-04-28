using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMover : MonoBehaviour {

    public Vector3 add;
    public Vector3 mousePos;
	
	void Update () {
        Vector3 pos = Input.mousePosition;
        mousePos = pos;
        pos = pos + add;
        this.transform.LookAt(pos);
	}
}
