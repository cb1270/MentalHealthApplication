# MentalHealthApplication

An application created in unity using `C#` designed to help people with mental health issues.

```cs
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
```
