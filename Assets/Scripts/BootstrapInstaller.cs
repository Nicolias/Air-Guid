using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BootstrapInstaller : MonoInstaller
{
    [SerializeField] private ButtonsFactory _buttonsFactory;
    [SerializeField] private AdsServise _adsServise;

    public override void InstallBindings()
    {
        Container.Bind<ButtonsFactory>().FromComponentOn(_buttonsFactory.gameObject).AsSingle();
        Container.Bind<AdsServise>().FromComponentOn(_adsServise.gameObject).AsSingle();
    }
}
    
