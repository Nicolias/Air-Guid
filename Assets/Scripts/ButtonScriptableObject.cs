using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Button", menuName = "Buttons")]
public class ButtonScriptableObject : ScriptableObject
{
    [SerializeField] private Sprite _buttonSprite;
    public Sprite ButtonSprite => _buttonSprite;

    [SerializeField] private string _discription;
    public string Discription => _discription;
}
