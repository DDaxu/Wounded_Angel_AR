using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class canvasHandler : MonoBehaviour
{
//public GameObject canvas; // Assign in inspector
     private bool canvasIsShowing;
     private bool buttonIsShowing;
     public GameObject tehtavaPainike;
     public GameObject tehtavaOK;
     public GameObject normiInfo;
     public GameObject suoritusInfo;
 

public void canvasLoader(){
          if(EventSystem.current.currentSelectedGameObject.name == "Tehtäväpainike"){
             canvasIsShowing = false;
             buttonIsShowing = true;
             tehtavaPainike.SetActive(canvasIsShowing);
             tehtavaOK.SetActive(buttonIsShowing);
          } else if(EventSystem.current.currentSelectedGameObject.name == "TehtäväOK"){
             canvasIsShowing = true;
             buttonIsShowing = false;
             tehtavaOK.SetActive(buttonIsShowing);
             tehtavaPainike.SetActive(canvasIsShowing);
          }else if(EventSystem.current.currentSelectedGameObject.name == "TehtäväJatka"){
             canvasIsShowing = true;
             buttonIsShowing = false;
             suoritusInfo.SetActive(buttonIsShowing);
             normiInfo.SetActive(canvasIsShowing);
          }
}
}
