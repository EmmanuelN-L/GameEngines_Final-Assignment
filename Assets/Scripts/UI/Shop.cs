using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Shop : MonoBehaviour
{
    public bool BouncyLauncherPurchased = false;
    public GameObject merchantShopPanel;
    public GameObject doctorShopPanel;
    public GameObject Merchant;
    public GameObject Doctor;
    public TMP_Text gunAmountText;
    public TMP_Text healAmountText;
    public TMP_Text healAmountInventoryText;
    public int amountGun;
    public int amountBandages;
    public UI_Script playerStats;
    public GameObject BouncyLauncherImage;
    public GameObject Inventory;

    public void OnOpenShop(InputValue button)
    {
        float doctorDistance = Vector3.Distance(Doctor.transform.position, transform.position);
        float merchantDistance = Vector3.Distance(Merchant.transform.position, transform.position);
        if (doctorDistance < 2)
        {
            if (!doctorShopPanel.activeSelf)
            {
                
                Time.timeScale = 0;
                doctorShopPanel.SetActive(true);
                Inventory.SetActive(false);

            }
            else
            {
                
                Time.timeScale = 1;
                doctorShopPanel.SetActive(false);
                Inventory.SetActive(true);
            }
                
        }
        if(merchantDistance < 2)
        {
            if (!merchantShopPanel.activeSelf)
            {
                Cursor.lockState = CursorLockMode.None;
                
                Time.timeScale = 0;
                merchantShopPanel.SetActive(true);
                Inventory.SetActive(false);
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Time.timeScale = 1;
                merchantShopPanel.SetActive(false);
                Inventory.SetActive(true);
            }

        }
    }

    public void OnIncrement(InputValue button)
    {
        if(merchantShopPanel.activeSelf)
        {
            if(amountGun < 1 && playerStats.getMoney() >= 100)
            {
                playerStats.setMoney(-100); 
                amountGun += 1;
                BouncyLauncherPurchased = true;
                BouncyLauncherImage.SetActive(true);
                gunAmountText.text = "X" + amountGun;
            }
        }

        if (doctorShopPanel.activeSelf)
        {
            if (playerStats.getMoney() >= 50)
            {
                playerStats.setMoney(-50);
                amountBandages += 1;
                healAmountText.text = "X" + amountBandages;
                healAmountInventoryText.text = "X" + amountBandages;
            }
        }

    }

    public void OnDecrement(InputValue button)
    {
        if (merchantShopPanel.activeSelf)
        {
            if (amountGun > 0)
            {
                playerStats.setMoney(100);
                amountGun -= 1;
                BouncyLauncherPurchased = false;
                BouncyLauncherImage.SetActive(false);
                gunAmountText.text = "X" + amountGun;
            }
        }

        if (doctorShopPanel.activeSelf)
        {
            if (amountBandages > 0)
            {
                playerStats.setMoney(50);
                amountBandages -= 1;
                healAmountText.text = "X" + amountBandages;
                healAmountInventoryText.text = "X" + amountBandages;
            }
        }
    }

    public void setBandages(int x)
    {
        amountBandages += x;
        healAmountText.text = "X" + amountBandages;
        healAmountInventoryText.text = "X" + amountBandages;
    }
    public int getBandages()
    {
        return amountBandages;
    }

    public void OnHeal(InputValue button)
    {
        Debug.Log("Healing");
        playerStats.SetHealth(40);
        setBandages(-1);

    }
}
