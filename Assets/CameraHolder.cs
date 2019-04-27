using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour {

    public Transform focus;
    public WheelCollider a;
    public WheelCollider b;
    public WheelCollider c;
    public WheelCollider d;
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
            mainCam.transform.LookAt(focus);

            if (countDown <= 0 || Grounded())
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

    bool Grounded()
    {
        return a.isGrounded && b.isGrounded && c.isGrounded && d.isGrounded;
    }
}
