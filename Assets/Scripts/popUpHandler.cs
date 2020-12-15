using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class popUpHandler : MonoBehaviour
{
    //clickable quads
    public GameObject kaarmeQuad;
    public GameObject kuolemaQuad;
    public GameObject jengiQuad;
    public GameObject lintuQuad;

    public GameObject enkeliQuad;

    //infos
    public GameObject kaarmeInfo;
    public GameObject kuolemaInfo;
    public GameObject jengiInfo;
    public GameObject lintuInfo;

    public GameObject enkeliInfo;

    //objects to show and hide
    public GameObject kaarme;
    public GameObject kuolema;
    public GameObject jengi;
    public GameObject lintu;
    public GameObject enkeli;

    
    bool popUpOn;
    bool visible = true;
    bool unvisible = false;
    public void showPop(string name){

       if(name == "kaarmeQuad" || name == "kaarme"){
            popUpOn = !popUpOn;
            kaarme.SetActive(popUpOn);
            if(kaarme.activeInHierarchy == true){
                kaarmeInfo.SetActive(unvisible);
                kaarmeQuad.SetActive(unvisible);
            }else if(kaarme.activeInHierarchy == false){
                kaarmeInfo.SetActive(visible);
                kaarmeQuad.SetActive(visible);
            }
        }
        else if(name == "kuolemaQuad" || name == "kuolema"){
            popUpOn = !popUpOn;
            kuolema.SetActive(popUpOn);
            if(kuolema.activeInHierarchy == true){
                kuolemaInfo.SetActive(unvisible);
                kuolemaQuad.SetActive(unvisible);
            }else if(kuolema.activeInHierarchy == false){
                kuolemaInfo.SetActive(visible);
                kuolemaQuad.SetActive(visible);
            }
        }else if(name == "lintuQuad" || name == "lintu"){
            popUpOn = !popUpOn;
            lintu.SetActive(popUpOn);
            if(lintu.activeInHierarchy == true){
                lintuInfo.SetActive(unvisible);
                lintuQuad.SetActive(unvisible);
            }else if(lintu.activeInHierarchy == false){
                lintuInfo.SetActive(visible);
                lintuQuad.SetActive(visible);
            }
        }else if(name == "jengiQuad" || name == "jengi"){
            popUpOn = !popUpOn;
            jengi.SetActive(popUpOn);
            if(jengi.activeInHierarchy == true){
                jengiInfo.SetActive(unvisible);
                jengiQuad.SetActive(unvisible);
            }else if(jengi.activeInHierarchy == false){
                jengiInfo.SetActive(visible);
                jengiQuad.SetActive(visible);
            }
        }
        else if(name == "enkeliQuad" || name == "enkeli"){
            popUpOn = !popUpOn;
            enkeli.SetActive(popUpOn);
            if(enkeli.activeInHierarchy == true){
                enkeliInfo.SetActive(unvisible);
                enkeliQuad.SetActive(unvisible);
            }else if(enkeli.activeInHierarchy == false){
                enkeliInfo.SetActive(visible);
                enkeliQuad.SetActive(visible);
            }
        }
    }
}
