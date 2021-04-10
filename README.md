# MentalHealthApplication

An application created in unity using `C#` designed to help people with mental health issues.

The application MUST be downloaded for it to run. 

## To run the application you first need to download the folder as a ZIP.
1. Click on the Down arrow ' ⌄ ' on the green button named 'code' on the [Main Page](https://github.com/cb1270/MentalHealthApplication), Click 'Download Zip'
2. Once the Zip is downloaded, click extract all and save the folder to your chosen location.
3. Once the folder is saved, open the folder named 'MentalHealthApp_CharlotteBudge' 
4. Double click 'Mental Health Application-Charlotte Budge.exe' to run the application. 


Click here to go straight to the location of the application on git to view the files >> [Mental Health Application Folder](https://github.com/cb1270/MentalHealthApplication/tree/main/MentalHealthApp_CharlotteBudge) <<<

### Snippet of the code used.

Scripts used to create the application clilck 'Scripts' to go to the folder >>> [Scripts](https://github.com/cb1270/MentalHealthApplication/tree/main/Assets/Scripts) <<<


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
