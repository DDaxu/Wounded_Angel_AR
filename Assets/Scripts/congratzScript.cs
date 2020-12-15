using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class congratzScript : MonoBehaviour
{
    public GameObject questComplete;
    public GameObject calculator;
       public TextMeshProUGUI quest;
    private bool buttonIsShowing = true;
    private bool calcIsShowing = false;
    private bool state = false;
    private int laskuri = 0;
    public void showProgress(){
       // if(state == false){
        questComplete.SetActive(buttonIsShowing);
        calculator.SetActive(calcIsShowing);
        laskuri++;
        changeProgress(laskuri);
        //}
      //  state = true;
        //if(state == false){
       // }
    }

    public void changeProgress(int laskuri){
        if(laskuri == 1){
            Debug.Log("eka");
            quest.text = "Hienoa, löysit käärmeen! Kokeile koskettaa käärmettä ja näe mitä tapahtuu.";
        }else if(laskuri == 2){
            Debug.Log("toka");
            quest.text = "Luurangot vaikuttavat mukavilta Kokeile saatko lisää tietoa esille.";
        }else if(laskuri == 3){
            quest.text = "Tämän maalauksen kaikki kirkossa varmasti huomaavat. Löydätkö kuvasta yksityiskohtia?";
        }else if(laskuri == 4){
            quest.text = "Näyttää siltä, että lintu on jäänyt jumiin yrittäessään ulos. Kokeile koskettaa lintua.";
        }else if(laskuri == 5){
            quest.text = "Auttavaiset pojat auttavat pudonnutta enkeliä.";
        }
    }

        void OnMouseOver()
    {
            if(Input.GetMouseButtonUp(0))
            {
             showProgress();
            }
        }
   void update(){
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit)){
               showProgress();
            }
        }
   }
}
