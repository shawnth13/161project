using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject ballPrefab;
    private List<GameObject> ballList = new List<GameObject>();
    private GameObject followTarget;
    [SerializeField]
    public float minDepth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballList.Add(Instantiate(ballPrefab, new Vector3(0, 0, 0), Quaternion.identity));
        }
        if (ballList.Count != 0){
            followTarget = ballList[0];
            foreach(GameObject ballObject in ballList){
                if ((followTarget.transform.GetChild(0).position.y < minDepth) || (ballObject.transform.GetChild(0).position.y < followTarget.transform.GetChild(0).position.y)){
                    followTarget = ballObject;
                }
            }
            if (followTarget.transform.GetChild(0).position.y > minDepth){
                transform.position = new Vector3(transform.position.x, followTarget.transform.GetChild(0).position.y, transform.position.z);
            }
        }
    }
}
