using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void exit()
    {
        SceneManager.LoadScene("Menu");
    }

}
