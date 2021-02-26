using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFood : MonoBehaviour
{


    public Texture2D playerHealthBar;
    public float curHealth = 100;
    public float maxHealth = 100;
    public float healthBarLength;
    private float _healthRegenRate = 0.5f;

    public Texture2D playerHungerBar;
    public float curFood = 100;
    public float maxFood = 100;
    public float hungerBarLength;
    private float _hungerDeplenSpeed = 0.2f;

    public Texture2D playerThirstBar;
    public float curWater = 100;
    public float maxWater = 100;
    public float thirstBarLength;
    private float _thirstDeplenSpeed = 0.4f;



    void Update()
    {
        //Adjusts Health, Hunger, and Thirst, depending on actions taken and time without food/ water.
        AdjustCurrentHealth(0);
        AdjustCurrentHunger(0);
        AdjustCurrentThirst(0);
    }


    public void AdjustCurrentHealth(int adj)
    {
        curHealth += adj;

        if (curHealth < 0)
        {
            curHealth = 0;
        }

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        //This is for the health bar length, according to the player's current health percent.
        healthBarLength = (Screen.width / 9) * (curHealth / (float)maxHealth);
    }

    public void AdjustCurrentHunger(int adj)
    {
        curFood += adj;

        if (curFood < 0)
        {
            curFood = 0;
        }

        if (curFood > maxFood)
        {
            curFood = maxFood;
        }

        if (curFood == 0)
        {
            curHealth -= _hungerDeplenSpeed * Time.deltaTime;
        }

        if (curFood >= 75 && curHealth < maxHealth)
        {
            curHealth += _healthRegenRate * Time.deltaTime;
        }
        //This is for the hunger bar length, according to the player's current hunger percent.
        hungerBarLength = (Screen.width / 9) * (curFood / (float)maxFood);
    }

    public void AdjustCurrentThirst(int adj)
    {
        curWater += adj;

        if (curWater < 0)
        {
            curWater = 0;
        }

        if (curWater > maxWater)
        {
            curWater = maxWater;
        }

        if (curWater == 0)
        {
            curHealth -= _thirstDeplenSpeed * Time.deltaTime;
        }

        if (curWater >= 30 && curHealth < maxHealth)
        {
            curHealth += _healthRegenRate * Time.deltaTime;
        }
        //This is for the thirst bar length, according to the player's current thirst percent.
        thirstBarLength = (Screen.width / 9) * (curWater / (float)maxWater);
    }
    //I added a GUI area, in case you want to add GUI stuff later on.
   void OnGUI()
    {
        VitalDisplay();
    }

    public void VitalDisplay()
    {
        //These are for the Hunger and Health GUI's. There is not a water one, so just copy and paste necesary info to create one.
        

        GUI.Box(new Rect(10, Screen.height - 84, 260, 74), "", "Box2Style");

        GUI.Label(new Rect(20, Screen.height - 74, 75, 32), "Health:");

        GUI.DrawTexture(new Rect(115, Screen.height - 74, healthBarLength, 25), playerHealthBar);

        GUI.Label(new Rect(20, Screen.height - 42, 75, 32), "Hunger:");

        GUI.DrawTexture(new Rect(115, Screen.height - 42, hungerBarLength, 25), playerHungerBar);
    }



}