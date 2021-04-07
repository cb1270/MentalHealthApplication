/* Created by Charotte Budge 
 * Date modified 07/04/2021
 
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Each public void is connected to a scene in the project and will be executable via using buttons.
public class MenuButtonControls : MonoBehaviour
{
    public void DisclaimerPage()
    {
        SceneManager.LoadScene(0);

    }
    public void MainMenuPage()
    {
        SceneManager.LoadScene(1);

    }
    public void MoodMonitor()
    {
        SceneManager.LoadScene(2);

    }
    public void FeelingGood()
    {
        SceneManager.LoadScene(3);

    }
    public void CouldBeBetter()
    {
        SceneManager.LoadScene(4);

    }

    public void FeelTerrible()
    {
        SceneManager.LoadScene(5);

    }
    public void PositiveQuotes()
    {
        SceneManager.LoadScene(6);

    }
    public void HelpfulWebsites()
    {
        SceneManager.LoadScene(7);

    }
    public void SmallTasks()
    {
        SceneManager.LoadScene(8);

    }
    public void BreathingExercise()
    {
        SceneManager.LoadScene(9);

    }
    public void WhatIsMentalHealthPg1()
    {
        SceneManager.LoadScene(10);

    }
    public void WhatIsMentalHealthPg2()
    {
        SceneManager.LoadScene(11);

    }
    public void WhatIsMentalHealthPg3()
    {
        SceneManager.LoadScene(12);

    }
    public void WhatIsMentalHealthRef()
    {
        SceneManager.LoadScene(13);

    }
    public void AnxietyStrategies()
    {
        SceneManager.LoadScene(14);

    }
  
}
