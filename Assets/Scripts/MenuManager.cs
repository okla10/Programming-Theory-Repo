using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class MenuManager : MonoBehaviour
{
    // ENCAPSULATION
    public TMP_InputField enterPlayerName { get; private set; }
    public static MenuManager instance { get; set; }
    public bool ball { get; private set; }
    public bool cube { get; private set; }
    public bool capsule { get; private set; }
    public TextMeshProUGUI playerName;

    public void Awake()
    {
        instance = this;
    }

    public void LoadScene()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene(1);
    }

    public void ChooseBall()
    {
        ball = true;
    }

    public void ChooseCube()
    {
        cube = true;
    }

    public void ChooseCapsule()
    {
        capsule = true;
    }


}
