using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK47 : WeaponComponent
{
    private Camera ViewCamera;

    private RaycastHit HitLocation;
    private GameObject Zombie;
    //public GameObject launchRound;
    public ParticleSystem muzzleFlash;
    private GameObject Soldier;
    private Enemy enemy;

    private Vector3 defaultRotation = new Vector3(0f, 0f, 0f);

    private void Awake()
    {
        ViewCamera = Camera.main;
    }
    protected new void FireWeapon()
    {


        if (WeaponStats.AmmoInClip > 0 && !Reloading && !WeaponHolder.Controller.IsRunning)
        {
            base.FireWeapon();

            Ray screenRay = ViewCamera.ScreenPointToRay(new Vector3(Crosshair.CurrentAimPosition.x,
                Crosshair.CurrentAimPosition.y, 0));

            if (Physics.Raycast(screenRay, out RaycastHit hit, WeaponStats.FireDistance,
                WeaponStats.WeaponHitLayer))
            {
                Vector3 RayDirection = HitLocation.point - ViewCamera.transform.position;

                Debug.DrawRay(ViewCamera.transform.position, RayDirection * WeaponStats.FireDistance, Color.red);
                HitLocation = hit;

                Debug.Log("HIT: "+ HitLocation.transform.tag);
                if (HitLocation.transform.tag == "Zombie")
                {
                    Zombie = HitLocation.transform.gameObject;
                    Zombie.GetComponent<ZombieFunc>().onTakeDamage(WeaponStats.Damage);
                }
                else if(HitLocation.transform.tag == "Soldier")
                {
                    Soldier = HitLocation.transform.gameObject;
                    enemy = Soldier.GetComponent<Enemy>();
                    if(enemy.health >= 0)
                    {
                        enemy.health -= WeaponStats.Damage;

                    }
                    else
                    {
                        enemy.defeated();
                    }

                }

                //Instantiate(launchRound, HitLocation.point, Quaternion.LookRotation(HitLocation.normal));
                //Rigidbody lr = launchRound.GetComponent<Rigidbody>();
            };
        }
        else if (WeaponStats.AmmoInClip <= 0)
        {
            if (!WeaponHolder) return;

            WeaponHolder.StartReloading();
        }
        muzzleFlash.Play();
    }

    private void OnDrawGizmos()
    {
        if (HitLocation.transform)
        {
            
            Gizmos.DrawWireSphere(HitLocation.point, 1.0f);
            

            


        }
    }
}
