using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AngelClick : MonoBehaviour
{
    public TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseOver()
    {
            if(Input.GetMouseButtonUp(0))
            {
             text.GetComponent<TextMesh>().text ="new Text u want";
            }
        }
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit)){
                text.GetComponent<TextMesh>().text ="Myllyn paras";
            }
        }
    }
}
