using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Transform ballObject;
    public Transform leftWall;
    public Transform rightWall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        leftWall.position = new Vector3(leftWall.position.x, ballObject.position.y, leftWall.position.z);
        rightWall.position = new Vector3(rightWall.position.x, ballObject.position.y, rightWall.position.z);
    }
}
