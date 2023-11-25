using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LogBookSystem : MonoBehaviour
{
    public Page_Template[] pageRight;
    public Page_Template[] pageLeft;
    public bool logBookOpen;
    public int page;
    public string type_Right;
    public string type_Left;
    private void Start()
    {
        
    }

    private void Update()
    {
        UpdateBookUI();
    }

    private void SwitchSide_Left()
    {
        page++;
    }
    private void SwitchSide_Right()
    {
        page++;
    }

    private void UpdateBookUI()
    {
        type_Right = null;
        type_Right = pageRight[page].pageType.ToString();
        
        switch (pageRight[page].pageType)
        {
            case Page_Template.page.Character:
                Debug.Log("character");
                break;
            
            case Page_Template.page.Powers:
                Debug.Log("Powers");
                break;
        }
        
        type_Left = null;
        type_Left = pageLeft[page].pageType.ToString();
        
        switch (pageLeft[page].pageType)
        {
            case Page_Template.page.Character:
                Debug.Log("character");
                break;
            
            case Page_Template.page.Powers:
                Debug.Log("Powers");
                break;
        }
    }
    
    
}
