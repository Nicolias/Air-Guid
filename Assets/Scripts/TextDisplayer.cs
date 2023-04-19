using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayer : MonoBehaviour
{
    [SerializeField] private Button _closeButton;

    [SerializeField] private TMP_Text _discriptionText, _lable;

    private void OnEnable()
    {
        _closeButton.onClick.AddListener(() => gameObject.SetActive(false));
    }

    private void OnDisable()
    {
        _closeButton.onClick.RemoveAllListeners();
    }

    public void ShowText(ButtonScriptableObject data)
    {
        gameObject.SetActive(true);

        _discriptionText.text = data.Discription;
        _lable.text = data.Lable;
    }
}
