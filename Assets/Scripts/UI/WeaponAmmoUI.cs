using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponAmmoUI : MonoBehaviour
{

    [SerializeField] private TMP_Text WeaponNameText;
    [SerializeField] private TMP_Text currentAmmoText;
    [SerializeField] private TMP_Text totalAmmoText;

    private WeaponComponent WeaponComponent;


    private void OnEnable()
    {
        PlayerEvent.OnWeaponEquipped += OnWeaponEquipped;
    }

    private void OnWeaponEquipped(WeaponComponent weaponComponent)
    {
        WeaponComponent = weaponComponent;
    }

    private void OnDisable()
    {
        PlayerEvent.OnWeaponEquipped -= OnWeaponEquipped;
    }

    private void Update()
    {
        if (!WeaponComponent) return;

        WeaponNameText.text = WeaponComponent.WeaponInformation.WeaponName;
        currentAmmoText.text = WeaponComponent.WeaponInformation.AmmoInClip.ToString() + " / ";
        totalAmmoText.text = WeaponComponent.WeaponInformation.AmmoAvailible.ToString();
    }
}
