using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    public GameObject followTarget;
    [SerializeField]
    public float minDepth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followTarget.transform.position.y > minDepth){
            transform.position = new Vector3(transform.position.x, followTarget.transform.position.y, transform.position.z);
        }
    }
}
