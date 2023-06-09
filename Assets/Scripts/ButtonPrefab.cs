using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonPrefab : MonoBehaviour
{
    private TextDisplayer _textDisplayer;
    private ButtonScriptableObject _data;

    private Button _button;
    public Button Button => _button;

    public void Initialize(TextDisplayer textDisplayer, ButtonScriptableObject data)
    {
        _textDisplayer = textDisplayer;

        _data = data;
        _button.image.sprite = data.ButtonSprite;
    }

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(ShowText);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveAllListeners();
    }

    private void ShowText()
    {
        _textDisplayer.ShowText(_data);
    }

}
