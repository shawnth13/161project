using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    private Transform leftFlipper;
    private Transform rightFlipper;

    [SerializeField]
    private int minRotation;
    [SerializeField]
    private int maxRotation;
    [SerializeField]
    private float upSpeed;
    [SerializeField]
    private float downSpeed;

    // Start is called before the first frame update
    void Start()
    {
        leftFlipper = transform.GetChild(0);
        rightFlipper = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left") || Input.GetKey("a")){
            Quaternion target = Quaternion.Euler(0, 0, maxRotation);
            leftFlipper.rotation = Quaternion.Slerp(leftFlipper.rotation, target,  Time.deltaTime * upSpeed);
        }else{
            Quaternion target = Quaternion.Euler(0, 0, minRotation);
            leftFlipper.rotation = Quaternion.Slerp(leftFlipper.rotation, target,  Time.deltaTime * downSpeed);
        }
        if (Input.GetKey("right") || Input.GetKey("d")){
            Quaternion target = Quaternion.Euler(0, 0, -maxRotation);
            rightFlipper.rotation = Quaternion.Slerp(rightFlipper.rotation, target,  Time.deltaTime * upSpeed);
        }else{
            Quaternion target = Quaternion.Euler(0, 0, -minRotation);
            rightFlipper.rotation = Quaternion.Slerp(rightFlipper.rotation, target,  Time.deltaTime * downSpeed);
        }
    }
}
