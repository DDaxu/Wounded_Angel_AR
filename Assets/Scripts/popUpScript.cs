using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class popUpScript : MonoBehaviour
{
    public popUpHandler popUp;
    void OnMouseOver()
    {
            if(Input.GetMouseButtonUp(0))
            {
             popUp.showPop(this.gameObject.name);
             //if(gameObject.GetComponent<focusQuad>().enabled == false)
             Debug.Log(this.gameObject.name);
            }
        }
   void update(){
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit)){
              popUp.showPop(this.gameObject.name);
            }
        }
   }
}
