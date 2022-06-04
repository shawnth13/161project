using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSetActive : MonoBehaviour
{
    public void toggleSetActive(){
        if (gameObject.activeSelf){
            gameObject.SetActive(false);
        }else{
            gameObject.SetActive(true);
        }
    }
}
