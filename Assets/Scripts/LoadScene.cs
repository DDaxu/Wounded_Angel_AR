using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public void SceneLoader(int SceneIndex){
        Debug.Log("asdasd");
        SceneManager.LoadScene(SceneIndex);
    }

}
