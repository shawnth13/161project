using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float ballBounciness = 0;
    public static float ballFriction = 0;
    public static float ballMass = 15;
    public static float ballGravityScale = 1;
    public PhysicsMaterial2D ballPhysics;
    public static float wallBounciness = 1;
    public static float wallFriction = 0;
    public PhysicsMaterial2D wallPhysics;
    public static float flipperBounciness = 0;
    public static float flipperFriction = 0;
    public PhysicsMaterial2D flipperPhysics;
    public static float bumperBounciness = 1;
    public static float bumperFriction = 0;
    public PhysicsMaterial2D bumperPhysics;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ballPhysics.bounciness = ballBounciness;
        ballBounciness = ballPhysics.bounciness;
        ballPhysics.friction = ballFriction;
        ballFriction = ballPhysics.friction;
        wallPhysics.bounciness = wallBounciness;
        wallBounciness = wallPhysics.bounciness;
        wallPhysics.friction = wallFriction;
        wallFriction = wallPhysics.friction;
        flipperPhysics.bounciness = flipperBounciness;
        flipperBounciness = flipperPhysics.bounciness;
        flipperPhysics.friction = flipperFriction;
        flipperFriction = flipperPhysics.friction;
        bumperPhysics.bounciness = bumperBounciness;
        bumperBounciness = bumperPhysics.bounciness;
        bumperPhysics.friction = bumperFriction;
        bumperFriction = bumperPhysics.friction;
    }

    public void changeBallBounciness(float value){
        ballBounciness += value;
    }

    public void changeBallFriction(float value){
        ballFriction += value;
    }

    public void changeBallMass(float value){
        ballMass += value;
    }

    public void changeBallGravityScale(float value){
        ballGravityScale += value;
    }

    public void changeWallBounciness(float value){
        wallBounciness += value;
    }

    public void changeWallFriction(float value){
        wallFriction += value;
    }

    public void changeFlipperBounciness(float value){
        flipperBounciness += value;
    }

    public void changeFlipperFriction(float value){
        flipperFriction += value;
    }

    public void changeBumperBounciness(float value){
        bumperBounciness += value;
    }

    public void changeBumperFriction(float value){
        bumperFriction += value;
    }
}
