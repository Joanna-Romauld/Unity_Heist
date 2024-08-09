using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.TimeZoneInfo;
using UnityEngine.SceneManagement;


public class NewLevel : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 0;

    private GameObject Plane;

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collision other)
        {
            if (other.gameObject.tag == "LevelChanger")
                LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
