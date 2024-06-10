  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public float gameOverLimitY;
    public GameObject gameOverText;
    public Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y < gameOverLimitY)
        {
            gameOverText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ReloadGame();
            }
        }


    }

    public void ReloadGame()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}
