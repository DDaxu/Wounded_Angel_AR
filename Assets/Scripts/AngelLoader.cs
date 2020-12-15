using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AngelLoader : MonoBehaviour
{
    public TextMesh text;
    [SerializeField]public int leveltoload;
    [SerializeField]public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnMouseOver()
    {
            if(Input.GetMouseButtonUp(0))
            {
             SceneLoader(leveltoload);
            }
        }
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit)){
                SceneLoader(leveltoload);
            }
        }
    }

    
    public void SceneLoader(int SceneIndex){
        SceneManager.LoadScene(SceneIndex);
    }

}
