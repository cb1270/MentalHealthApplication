using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this code is connected to the close app button which will enable the user to exit the app.
public class ExitApplication : MonoBehaviour
{

    public void ExitTheApp()
    {
        Application.Quit();
        Debug.Log("Application is exiting");
        //to test it is working when running in unity
    }

}

