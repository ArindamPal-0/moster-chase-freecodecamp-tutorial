using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int _charIndex;
    public int CharIndex
    {
        get {return _charIndex;}
        set {_charIndex = value;}
    }

    [SerializeField]
    private GameObject[] characters;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else 
        {
            Destroy(gameObject);
        }
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishLoading;
    }

    void OnLevelFinishLoading(Scene scene, LoadSceneMode mode)
    {
        if(scene.name == "Gameplay")
        {
            Instantiate(characters[CharIndex]);
        }
    }
}// class
