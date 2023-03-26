using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartMenuScript : MonoBehaviour
{

    public void StartGame(){
        Application.LoadLevel(1);
    }

 
    public void ExitGame(){
        Application.Quit();
    }

}
