using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum WeaponType
{
    None,
    BouncyLauncher,
    Ak47,
}

[Serializable]
public struct WeaponStats
{
    public WeaponType WeaponType;
    public string WeaponName;
    public float Damage;
    public int AmmoInClip;
    public int ClipSize;
    public int AmmoAvailible;
    public float FireStartDelay;
    public float FireRate;
    public float FireDistance;
    public bool Repeating;
    public LayerMask WeaponHitLayer;
}

public class WeaponComponent : MonoBehaviour
{
    public Transform GripLocation => GripIKLocation;
    [SerializeField] private Transform GripIKLocation;


    public WeaponStats WeaponInformation => WeaponStats;
    [SerializeField] protected WeaponStats WeaponStats;

    public bool Firing { get; private set; }
    public bool Reloading { get; private set; }

    //public WeaponStats WeaponStats;

    protected WeaponHolder WeaponHolder;
    protected CrosshairScript Crosshair;
    protected Camera MainCamera;

    private void Awake()
    {
        MainCamera = Camera.main;
    }

    public void Initialize(WeaponHolder weaponHolder, CrosshairScript crosshair)
    {
        WeaponHolder = weaponHolder;
        Crosshair = crosshair;
    }


    public virtual void StartFiringWeapon()
    {
        Firing = true;
        if(WeaponStats.Repeating)
        {
            InvokeRepeating(nameof(FireWeapon), WeaponStats.FireStartDelay, WeaponStats.FireRate);
        }
        else
        {
            FireWeapon();
        }

    }

    public virtual void StopFiringWeapon()
    {
        Firing = false;
        CancelInvoke(nameof(FireWeapon));

    }

    protected virtual void FireWeapon()
    {
        // Debug.Log("Firing Weapon");
        WeaponStats.AmmoInClip--; 
    }

    public virtual void startReloading()
    {
        Reloading = true;
        reloadWeapon();
    }

    public virtual void stopReloading()
    {
        Reloading = false;
    }

    protected virtual void reloadWeapon()
    {
        // AmmoInClip = 20  AmmoAvailible = 40 ClipSize = 20 BulletsToReload =
        int bulletsToReload = WeaponStats.AmmoInClip - WeaponStats.ClipSize;

        if (WeaponStats.AmmoInClip == WeaponStats.ClipSize)
        {
            Debug.Log("Clip is full!");
        }
        else if (bulletsToReload < 0 && WeaponStats.AmmoAvailible + bulletsToReload >= 0)
        {
            WeaponStats.AmmoInClip = WeaponStats.ClipSize;
            WeaponStats.AmmoAvailible += bulletsToReload;
        }
        else
        {
            WeaponStats.AmmoInClip += WeaponStats.AmmoAvailible;
            WeaponStats.AmmoAvailible = 0;
        }
        
    }
}
