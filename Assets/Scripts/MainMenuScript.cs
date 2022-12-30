using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;

    private GameObject ball;
    private Vector3 pos;

    void Update()
    {
        BallSpawner();

        if(ball.transform.position.y < -15)
        {
            Destroy(ball);
        }
    }
    void BallSpawner()
    {
        pos = new Vector3(Random.Range(-6.0f, 6.0f), transform.position.y, Random.Range(-5.3f, 5.3f));

        if (ball == null)
        {
            ball = Instantiate(ballPrefab, pos, Quaternion.identity) as GameObject;
            ball.transform.parent = transform;
        }
    }
    public void AppExit()
    {
        Application.Quit();
        print("EXIT");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
