using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    //contains the exact order of screens presented => Stoory, Exercise, inventory, Homescreen
    static string[] story_line = new string[] { "HomePage", "HomePage", "Story_1", "Story_1-1", "Story_1-2"};
    static int indexCurrentScene;


    // Start is called before the first frame update
    public void Start()
    {
        SceneManager.LoadScene("HomePage");
        GameData data = SaveSystem.LoadGame();
        indexCurrentScene = data.indexCurrentScene;
    }

    public static void Play(string sceneName = "")
    {
        if (sceneName == "HomePage" && story_line[indexCurrentScene] == "HomePage")
        {
            indexCurrentScene++;
            Play("HomePage");
        }
        else
        {
            SceneManager.LoadScene(story_line[indexCurrentScene]);
            indexCurrentScene++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnApplicationQuit()
    {
        SaveSystem.SaveGame(indexCurrentScene);
    }
}
