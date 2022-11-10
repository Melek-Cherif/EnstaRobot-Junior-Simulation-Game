using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public float MotorForce, SteerForce, BreakForce;
    public WheelCollider wheelfrontleft, wheelfrontright, wheelbackleft, wheelbackright;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * MotorForce;
        float h = Input.GetAxis("Horizental") * SteerForce;

        wheelbackleft.motorTorque = v;
        wheelbackright.motorTorque = v;

        wheelfrontleft.steerAngle = h;
        wheelfrontright.steerAngle = h;

        if (Input.GetKey(KeyCode.Space))
        {
            wheelbackleft.brakeTorque = BreakForce;
            wheelbackright.brakeTorque = BreakForce;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            wheelbackleft.brakeTorque = 0;
            wheelbackright.brakeTorque = 0;
        }

        if (Input.GetAxis("Vertical") == 0) 
        {
            wheelbackleft.brakeTorque = BreakForce;
            wheelbackright.brakeTorque = BreakForce;
        }
        else 
        {
            wheelbackleft.brakeTorque = 0;
            wheelbackright.brakeTorque = 0;
        }
    }
}
