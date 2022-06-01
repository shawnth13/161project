using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipperController : MonoBehaviour
{
    public float speed = 0f;
    private HingeJoint2D hingeJoint2D;
    private JointMotor2D jointMotor;
    // Start is called before the first frame update
    void Start()
    {
        hingeJoint2D = GetComponent<HingeJoint2D>();
        jointMotor = hingeJoint2D.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            jointMotor.motorSpeed = speed;
            hingeJoint2D.motor = jointMotor;
        }else{
            jointMotor.motorSpeed = -speed;
            hingeJoint2D.motor = jointMotor;
        }
    }
}
