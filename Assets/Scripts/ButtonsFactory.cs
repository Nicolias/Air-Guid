using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ButtonsFactory : MonoBehaviour
{
    [SerializeField] private TextDisplayer _textDisplayer;

    [SerializeField] private List<ButtonScriptableObject> _buttonsData;
    [SerializeField] private Transform _container;
    [SerializeField] private ButtonPrefab _buttonPrefab;

    private AdsServise _adsServise;

    private List<ButtonPrefab> _allButtons = new();
    public List<ButtonPrefab> AllButtons => _allButtons;

    [Inject]
    private void Construct(AdsServise adsServise)
    {
        _adsServise = adsServise;
    }

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
            _allButtons.Add(button);
        }

        _adsServise.AddButtonsForShowAds(_allButtons);
    }
}
