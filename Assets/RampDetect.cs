using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampDetect : MonoBehaviour {

    public CameraHolder cameraHolder;
    public Transform position;

    private void OnTriggerEnter(Collider other)
    {
        if (other is BoxCollider) { 
            cameraHolder.SetFollowCam(position);
        }
    }
}
