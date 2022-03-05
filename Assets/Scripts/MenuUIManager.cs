using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUIManager : MonoBehaviour
{

    public static string input;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        MainManager.Instance.SaveHighScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();

#else
        Application.Quit();

#endif
    }
}
