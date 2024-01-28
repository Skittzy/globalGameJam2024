using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionInventory : MonoBehaviour
{
    public static PotionInventory Instance;

    public int maxPotions = 3;
    private int currentPotions = 3;

    public Image[] potionImages;
    public Sprite fullPotion;
    public Sprite emptyPotion;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdatePotionUI();
    }

    public bool CanCollectPotion()
    {
        return currentPotions < maxPotions;
    }

    public void AddPotion()
    {
        if (currentPotions < maxPotions)
        {
            currentPotions++;
            UpdatePotionUI();
        }
    }

    public void UpdatePotionUI()
    {
        for (int i = 0; i < potionImages.Length; i++)
        {
            if (i < currentPotions)
            {
                potionImages[i].sprite = fullPotion;
            }
            else
            {
                potionImages[i].sprite = emptyPotion;
            }
        }
    }
}
