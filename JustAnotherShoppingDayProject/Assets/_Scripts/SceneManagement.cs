using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene("Play");
    }

    public void Close(){
        Application.Quit();
    }
}
