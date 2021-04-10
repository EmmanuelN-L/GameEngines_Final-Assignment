using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStats : MonoBehaviour
{
    public int CurrentHealth { get; set; }
    public int MaxHealth { get; set; }

    public int CurrentMoney{ get; set; }


    public UI_Script healthBar;

    private void Start()
    {
        
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
        CurrentMoney = 0;
        
    }

    //public void OnJump(InputValue button)
    //{
    //    Debug.Log("Gain Health");
    //    CurrentHealth += 20;

    //    healthBar.SetHealth(CurrentHealth);
    //}

    //public void OnTakeDamage(InputValue button)
    //{
    //    Debug.Log("Taking Damage");
    //    CurrentHealth -= 20;

    //    healthBar.SetHealth(CurrentHealth);
    //}
}
