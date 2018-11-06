using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public AudioSource music;
    public AudioSource transitionSound;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            transitionSound.Play();
            SceneManager.LoadScene(DraftManager.SCENE_NAME);
            music.volume *= 0.25f;
        }
    }
}
