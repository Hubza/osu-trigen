﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopupControl : MonoBehaviour
{
    
    public Button popupclose;
    public Button creditsbutt;
    public Button privacybutt;
    public Button websitebutt;
    public Button sourcebutt;
    public Button reportbutt;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CanvasGroup>().alpha = 0;

        //Button credclick = creditsbutt.GetComponent<Button>();
        //credclick.onClick.AddListener(credpress);

        //Button closeclick = popupclose.GetComponent<Button>();
        //closeclick.onClick.AddListener(closepress);

        Button privacyclick = privacybutt.GetComponent<Button>();
        privacyclick.onClick.AddListener(privacypress);

        Button webclick = websitebutt.GetComponent<Button>();
        webclick.onClick.AddListener(webpress);

        Button sourceclick = sourcebutt.GetComponent<Button>();
        sourceclick.onClick.AddListener(sourcepress);

        Button reportclick = reportbutt.GetComponent<Button>();
        sourceclick.onClick.AddListener(reportpress);

        GetComponent<CanvasGroup>().interactable = false;
    }
    public void reportpress()
    {
        Application.OpenURL("https://github.com/hubza/osu-trigen/issues/new");
    }
    public void credpress()
    {
        if (GetComponent<CanvasGroup>().alpha == 1)
        {
            GetComponent<CanvasGroup>().alpha = 0;
            GetComponent<CanvasGroup>().interactable = false;
        }
        else
        {
            GetComponent<CanvasGroup>().alpha = 1;
            GetComponent<CanvasGroup>().interactable = true;
        }
    }

    public void closepress()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
    }

    public void privacypress()
    {
        Application.OpenURL("https://eclipsed.hubza.co.uk/programs/osutrigen/trigen-privacy-policy");
    }

    public void sourcepress()
    {
        Application.OpenURL("https://github.com/hubza/osu-trigen/");
    }

    public void webpress()
    {
        Application.OpenURL("https://www.hubza.co.uk");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
