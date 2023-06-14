using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene(string sceneName)
    {
        Debug.Log("kepanggi 2");
        SceneManager.LoadScene(sceneName);
    }

    // fungsi untuk keluar dari aplikasi
    public void QuitApp()
    {
        Application.Quit();
    }
}
