using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(1);
            }
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
