using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void newScene()
    {
        //SceneManager.UnloadSceneAsync("Home Scene");
        SceneManager.LoadScene("Turret Warfare", LoadSceneMode.Single);
        //Debug.Log("Works");
    }
}
