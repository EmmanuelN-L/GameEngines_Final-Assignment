using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponHolder : MonoBehaviour
{
    [Header("weapon To Spawn"), SerializeField]
    private GameObject WeaponToSpawn;

    [SerializeField] private Transform weaponSocketLocation;

    private Transform GripIKLocation;

    private bool wasFiring = false;
    private bool FiringPressed = false;

    //Components
    public Character.PlayerController Controller => PlayerController;
    private Character.PlayerController PlayerController;

    private CrosshairScript PlayerCrosshair;
    private Animator PlayerAnimator;

    //Ref
    private Camera ViewCamera;
    private WeaponComponent EquippedWeapon;

    private static readonly int AimHorizontalHash = Animator.StringToHash("AimHorizontal");
    private static readonly int AimVerticalHash = Animator.StringToHash("AimVertical");
    private static readonly int IsFiringHash = Animator.StringToHash("IsFiring");
    private static readonly int IsReloadingHash = Animator.StringToHash("IsReloading");
    private static readonly int WeaponTypeHash = Animator.StringToHash("WeaponType");

    private void Awake()
    {

        PlayerAnimator = GetComponent<Animator>();
        PlayerController = GetComponent<Character.PlayerController>();
        if(PlayerController)
        {
            PlayerCrosshair = PlayerController.CrossHair;
        }

        ViewCamera = Camera.main;
    }


    // Start is called before the first frame update
    void Start()
    {
       GameObject spawnWeapon =  Instantiate(WeaponToSpawn,  weaponSocketLocation);
        if (spawnWeapon)
        {
            EquippedWeapon = spawnWeapon.GetComponent<WeaponComponent>();
            if(EquippedWeapon)
            {
                EquippedWeapon.Initialize(this, PlayerCrosshair);
                GripIKLocation = EquippedWeapon.GripLocation;
                PlayerAnimator.SetInteger(WeaponTypeHash, (int)EquippedWeapon.WeaponInformation.WeaponType);               
            }
        }

        PlayerEvent.Invoke_OnWeaponEquipped(EquippedWeapon);
    }

    private void OnAnimatorIK(int layerIndex)
    {
        PlayerAnimator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1f);
        PlayerAnimator.SetIKPosition(AvatarIKGoal.LeftHand, GripIKLocation.position);
    }

    public void OnFire(InputValue button)
    {  
        
        FiringPressed = button.isPressed;
       
        
        if (button.isPressed)
        {
            if (EquippedWeapon.WeaponInformation.AmmoInClip <= 0) return;
            PlayerController.IsFiring = true;
            PlayerAnimator.SetBool(IsFiringHash, PlayerController.IsFiring);
            EquippedWeapon.StartFiringWeapon();
            Debug.Log("hello");
        }
        else
        {
            PlayerController.IsFiring = false;
            PlayerAnimator.SetBool(IsFiringHash, PlayerController.IsFiring);
            EquippedWeapon.StopFiringWeapon();
        }

    }
    public void startFiring()
    {
        FiringPressed = true;
        PlayerController.IsFiring = true;
        PlayerAnimator.SetBool(IsFiringHash, PlayerController.IsFiring);
        EquippedWeapon.StartFiringWeapon();
    }


    public void stopFiring()
    {
        FiringPressed = false;
        PlayerController.IsFiring = false;
        PlayerAnimator.SetBool(IsFiringHash, PlayerController.IsFiring);
        EquippedWeapon.StopFiringWeapon();
    }

    public void OnReload(InputValue button)
    {
        StartReloading();
    }

    public void StartReloading()
    {
        if (EquippedWeapon.WeaponInformation.AmmoAvailible <= 0 && PlayerController.IsFiring)
        {
            wasFiring = true;
            stopFiring();
        }

        PlayerController.IsReloading = true;
        PlayerAnimator.SetBool(IsReloadingHash, PlayerController.IsReloading);
        EquippedWeapon.startReloading();

        InvokeRepeating(nameof(StopReloading), 0, 0.1f);
    }

    public void StopReloading()
    {
        if (PlayerAnimator.GetBool(IsReloadingHash)) return;

        PlayerController.IsReloading = false;

        EquippedWeapon.stopReloading();

        CancelInvoke(nameof(StopReloading));

        if(wasFiring && FiringPressed)
        {
            startFiring();
            wasFiring=false;
        }
    }
    public void OnLook(InputValue delata)
    {
        Vector2 independentMousePosition = ViewCamera.ScreenToViewportPoint(PlayerCrosshair.CurrentAimPosition);

        //Debug.Log(independentMousePosition);

        PlayerAnimator.SetFloat(AimHorizontalHash, independentMousePosition.x);
        PlayerAnimator.SetFloat(AimVerticalHash, independentMousePosition.y);
    }
}
