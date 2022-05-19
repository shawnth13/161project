using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Transform leftWall;
    private Transform rightWall;
    // Start is called before the first frame update
    void Start()
    {
        leftWall = transform.parent.GetChild(1);
        rightWall = transform.parent.GetChild(2);
    }

    // Update is called once per frame
    void Update()
    {
        leftWall.position = new Vector3(leftWall.position.x, transform.position.y, leftWall.position.z);
        rightWall.position = new Vector3(rightWall.position.x, transform.position.y, rightWall.position.z);
    }
}
