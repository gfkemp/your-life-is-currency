using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public WheelCollider fl;
    public WheelCollider fr;
    public WheelCollider bl;
    public WheelCollider br;

    [SerializeField]
    private string forwardAxis;
    [SerializeField]
    private string steeringAxis;

    public float speed = 10;
    public float steeringRatio = 10;
    public float brakeAmount = 10;

    private void Start()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.centerOfMass = new Vector3(-0.1f, 0, 0);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            this.transform.position = Vector3.zero;
            this.transform.rotation = Quaternion.identity;
        }

        if (Input.GetAxis(forwardAxis) < 0)
        {
            bl.motorTorque = speed;
            br.motorTorque = speed;
            fl.motorTorque = speed;
            fr.motorTorque = speed;
        }
        else if (Input.GetAxis(forwardAxis) > 0)
        {
            bl.motorTorque = -speed/2;
            br.motorTorque = -speed/2;
            fl.motorTorque = -speed / 2;
            fr.motorTorque = -speed / 2;
        }
        else
        {
            bl.motorTorque = 0;
            br.motorTorque = 0;
            fl.motorTorque = 0;
            fr.motorTorque = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            bl.brakeTorque = brakeAmount;
            br.brakeTorque = brakeAmount;
            fl.brakeTorque = brakeAmount;
            fr.brakeTorque = brakeAmount;
        }
        else
        {
            bl.brakeTorque = 0;
            br.brakeTorque = 0;
            fl.brakeTorque = 0;
            fr.brakeTorque = 0;
        }

        float steer = Input.GetAxis(steeringAxis) * steeringRatio;

        fl.steerAngle = steer;
        fr.steerAngle = steer;
    }
}
