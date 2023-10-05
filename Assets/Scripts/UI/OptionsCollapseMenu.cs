using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsCollapseMenu : MonoBehaviour
{
    [SerializeField] private float animationSpeed;
    private Vector2 closedPosition = new(Convert.ToSingle(Screen.width - 20), Convert.ToSingle(Screen.height - 70));
    private Vector2 openedPosition = new(Convert.ToSingle(Screen.width - 20), Convert.ToSingle(Screen.height - 720));
    private bool isMenuOpen = false;
    private UIAudioManager UIAinstance;

    private void Start()
    {
        UIAinstance = UIAudioManager.GetInstance();
    }

    public void CollapseOrOpenMenu()
    {
        if (isMenuOpen)
        {
            transform.LeanMove(closedPosition, animationSpeed).setEaseOutQuart();
            UIAinstance.PlayAudio("TurnLeft");
            isMenuOpen = false;
        }
        else if (!isMenuOpen)
        {
            transform.LeanMove(openedPosition, animationSpeed).setEaseOutQuart();
            UIAinstance.PlayAudio("TurnRight");
            isMenuOpen = true;
        }
    }
}
