using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    public LoadScene LoadScene;
    void Start()
    {
        
    }
    void OnMouseOver()
    {
            if(Input.GetMouseButtonUp(0))
            {
                LoadScene.SceneLoader(1);
            }
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
