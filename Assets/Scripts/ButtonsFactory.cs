using System.Collections.Generic;
using UnityEngine;

public class ButtonsFactory : MonoBehaviour
{
    [SerializeField] private TextDisplayer _textDisplayer;

    [SerializeField] private List<ButtonScriptableObject> _buttonsData;
    [SerializeField] private Transform _container;
    [SerializeField] private ButtonPrefab _buttonPrefab;

    private void Start()
    {
        SpawnButtons(_buttonsData);
    }

    public void SpawnButtons(List<ButtonScriptableObject> buttonsData)
    {
        foreach (var buttonData in buttonsData)
        {
            var button = Instantiate(_buttonPrefab, _container);
            button.Initialize(_textDisplayer, buttonData);
        }
    }
}
