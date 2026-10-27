using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayVideo : MonoBehaviour
{
    public VideoPlayer movie;
    public float waitTime = 5f;
    public string mainMenu;

    private float timer = 0f;

    void Start()
    {
        Time.timeScale = 1f;

        GetComponent<RawImage>().texture = movie.targetTexture;
        movie.Play();

        // Cursor.visible = false;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            SceneManager.LoadScene(mainMenu);
        }
    }
}
