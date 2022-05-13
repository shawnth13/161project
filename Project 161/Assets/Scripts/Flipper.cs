using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    private Transform leftFlipper;
    
    // Start is called before the first frame update
    void Start()
    {
        leftFlipper = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Quaternion target = Quaternion.Euler(0, 0, 0);
        if (horizontalInput != 0){
            target = Quaternion.Euler(0, 0, 90);
        }
        leftFlipper.rotation = Quaternion.Slerp(leftFlipper.rotation, target,  Time.deltaTime * 5.0f);
    }
}
