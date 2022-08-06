using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}// class
