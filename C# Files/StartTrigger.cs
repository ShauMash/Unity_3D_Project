using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter()
    {
        // To start the same level if the player exits through "Start"
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
    }
}
