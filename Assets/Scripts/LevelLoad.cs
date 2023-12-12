using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Method to load Level 1 when a button is clicked
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    // Update is called once per frame
    public void LooseYouLoad()
    {
        SceneManager.LoadScene("Lose Screen");
    }
    public void LoadSceneByName(string Level1)
    {
        SceneManager.LoadScene("Level 1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
