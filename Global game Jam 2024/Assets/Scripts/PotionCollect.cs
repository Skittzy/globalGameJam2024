using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionCollect : MonoBehaviour
{
    public static int totalPotions = 0; 

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            if (PotionInventory.Instance.CanCollectPotion())
            {
                totalPotions++;
                PotionInventory.Instance.AddPotion();
                Destroy(gameObject);
            }
        }
    }
}
