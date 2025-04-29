using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        // To start the same level if the player exits through "Start"
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
}
