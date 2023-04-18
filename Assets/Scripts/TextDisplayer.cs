using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayer : MonoBehaviour
{
    [SerializeField] private Button _closeButton;
    [SerializeField] private TMP_Text _tmpText;

    private void OnEnable()
    {
        _closeButton.onClick.AddListener(() => gameObject.SetActive(false));
    }

    private void OnDisable()
    {
        _closeButton.onClick.RemoveAllListeners();
    }

    public void ShowText(string text)
    {
        gameObject.SetActive(true);

        _tmpText.text = text;
    }
}
