using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPostManager : MonoBehaviour
{
    [Header("Buttons")] [Space(5)]
    
    [SerializeField] private UnityEngine.UI.Button backButton;
    [SerializeField] private UnityEngine.UI.Button proceedToPostButton;
    
    
    [Space(12)] [Header("Game Objects")] [Space(5)] 
    
    [SerializeField] private GameObject newPost01Scene;
    [SerializeField] private GameObject newPost02Scene;
    [SerializeField] private GameObject homeScene;


    private void Start()
    {
        UnityEngine.Assertions.Assert.IsNotNull(backButton);
        UnityEngine.Assertions.Assert.IsNotNull(proceedToPostButton);
        
        backButton.onClick.AddListener(On_Click_BackButton);
        proceedToPostButton.onClick.AddListener(On_Click_ProceedToPostButton);
    }

    private void On_Click_ProceedToPostButton()
    {
        newPost01Scene.SetActive(false);
        newPost02Scene.SetActive(true);
    }

    private void On_Click_BackButton()
    {
        newPost01Scene.SetActive(false);
        homeScene.SetActive(true);
    }
}