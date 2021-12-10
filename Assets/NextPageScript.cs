using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextPageScript : MonoBehaviour
{
    //SceneManager to use in action
    SceneManager sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        sceneManager = new SceneManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSceneOneButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OnSceneZeroButton()
    {
        SceneManager.LoadScene(0);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}
