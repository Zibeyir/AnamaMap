using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] GameObject[] Buttons;
    AnimationController[] animationController;
    void Start()
    {
        animationController = new AnimationController[Buttons.Length];
        for (int i = 0; i < Buttons.Length; i++)
        {
            animationController[i] = Buttons[i].GetComponent<AnimationController>();
        }
    }

    public void AOE_Button()
    {

    }
    public void LGB_Button()
    {

    }
    public void MTE_Button()
    {

    }
    public void RUB_Button()
    {

    }
}
