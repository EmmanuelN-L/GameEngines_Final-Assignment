using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UI_Script : MonoBehaviour
{
    public PlayerStats playerStats;
    public TMP_Text moneyText;
    public Slider slider;

    private void Start()
    {
        SetMaxHealth(100);
        setMoney(playerStats.CurrentMoney);
    }


    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        playerStats.CurrentHealth += health;
        playerStats.CurrentHealth = Mathf.Clamp(playerStats.CurrentHealth, 0, playerStats.MaxHealth);
        slider.value = playerStats.CurrentHealth;
        if(slider.value <= 0)
        {
            Debug.Log("You dead");
        }
        
    }
    public int getMoney()
    {
        return playerStats.CurrentMoney;
    }
    public void setMoney(int amount)
    {
        playerStats.CurrentMoney += amount;
        moneyText.text = playerStats.CurrentMoney.ToString();
    }

    //public void Update()
    //{
    //    Debug.Log("Health" + playerStats.CurrentHealth);
    //}


}
