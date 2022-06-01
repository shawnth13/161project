using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator LeftFlipperAnimator;
    public Animator RightFlipperAnimator;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftFlipperAnimator.ResetTrigger("Pressed");
            LeftFlipperAnimator.SetTrigger("Pressed");

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightFlipperAnimator.ResetTrigger("Pressed");
            RightFlipperAnimator.SetTrigger("Pressed");
        }
    }
}