using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject title;
    public GameObject mainButtons;
    public GameObject optionsMenu;

    public void OpenOptions()
    {
        title.SetActive(false);
        mainButtons.SetActive(true);
        optionsMenu.SetActive(true);
    }

    /*public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }*/
}
