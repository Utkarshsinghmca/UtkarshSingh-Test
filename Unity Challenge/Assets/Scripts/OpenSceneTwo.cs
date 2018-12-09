using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenSceneTwo : MonoBehaviour {


    public void  Openscenetwo()
    {
        SceneManager.LoadScene("Gamescene");
    }

    public void Opensceneone()
    {
        SceneManager.LoadScene("Gamemenu");
    }
}
