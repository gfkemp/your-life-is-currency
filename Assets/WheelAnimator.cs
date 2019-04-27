using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelAnimator : MonoBehaviour {

    private WheelCollider wc;
    private Transform model;
	// Use this for initialization
	void Start () {
        wc = this.GetComponent<WheelCollider>();
        model = GetComponentInChildren<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position;
        Quaternion rotation;

        wc.GetWorldPose(out position, out rotation);
        model.rotation = rotation;
        model.position = position;
	}
}
