using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallFrictionValue : MonoBehaviour
{
    private TextMeshProUGUI textValue;
    // Start is called before the first frame update
    void Start()
    {
        textValue = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textValue.text = GameController.ballFriction.ToString("#.0");
    }
}
