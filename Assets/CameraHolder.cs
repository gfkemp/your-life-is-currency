using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour {

    public Transform focus;
    public Transform car;
    public GameObject mainCam;

    float countDown = 10;
    private bool normalTrack = true;
    Transform oldPosition;

	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (normalTrack) { 
            this.transform.position = focus.transform.position;
        }
        else
        {
            countDown -= 0.1f;
            mainCam.transform.LookAt(car);

            if (countDown <= 0)
            {
                normalTrack = true;
                mainCam.transform.localPosition = new Vector3(10, 10, -10);
                mainCam.transform.localRotation = Quaternion.Euler(new Vector3(33.759f, -45f, 0f));
            }
        }
	}

    internal void SetFollowCam(Transform position)
    {
        normalTrack = false;
        oldPosition = mainCam.transform;
        mainCam.transform.SetPositionAndRotation(position.position, position.rotation);

        countDown = 10;
    }
}
