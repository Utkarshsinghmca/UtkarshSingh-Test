using UnityEngine;
using System.Collections;


public class EXIT : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    public void Exitapp()
    {

        Application.Quit();
    }
}