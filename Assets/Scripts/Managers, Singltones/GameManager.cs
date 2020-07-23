﻿using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singletone

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
           Destroy(gameObject); 
        }
        else
        {
            Instance = this;
        }
    }

    #endregion

    public bool startGame = true;
    // Start is called before the first frame update
    void Start()
    {
       DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
