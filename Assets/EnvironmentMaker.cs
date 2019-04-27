using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMaker : MonoBehaviour {

    public GameObject building;
    public GameObject ramp;
    public GameObject spawner;
    public CameraHolder cameraHolder;

    void Start () {
		//8x8
        for (int x = -4; x < 4; x++)
        {
            for (int z = -4; z < 4; z++)
            {
                GameObject b = Instantiate(building, new Vector3(x*60, 0, z*60), Quaternion.identity);
                b.transform.parent = this.transform;

                GameObject r = Instantiate(ramp);
                r.transform.position = r.transform.position + new Vector3(x * 60 , 0, z * 60  +30);
                r.transform.parent = this.transform;
                r.GetComponentInChildren<RampDetect>().cameraHolder = cameraHolder;

                GameObject s = Instantiate(spawner);
                s.transform.position = s.transform.position + new Vector3(x * 60, 0, z * 60 + 30);
                s.transform.parent = this.transform;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
