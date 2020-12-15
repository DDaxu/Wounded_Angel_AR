using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public class TextHandler : MonoBehaviour
{
    int laskuri = 1;
    //public GameObject TextManager;
    public TextMeshProUGUI calculatorText;
    bool phase = false;
    bool phase2 = false;
    public TextUpdater updater;
    public congratzScript progress;
   public void calculator(){
       laskuri++;
   }
   public int parser(int x){
       x = Int32.Parse(calculatorText.text);
       Debug.Log("tämä on parser " + laskuri);
       return x;
   }
   public void tekstinVaihto(){
      laskuri = parser(laskuri);
       updater.textUpdater(laskuri);
   }
    void OnMouseOver()
    {
            if(Input.GetMouseButtonUp(0))
            {
             tekstinVaihto();
             progress.showProgress();
             //if(gameObject.GetComponent<focusQuad>().enabled == false)
            }
        }
   void update(){
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit)){
                tekstinVaihto();
            }
        }
   }
}
