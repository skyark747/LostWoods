using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu ]
public class Loot : ScriptableObject
{
    public string lootName;
    public Sprite lootsprite;
    public int dropChance;

    public Loot(string lootName, int dropChance)
    {
        this.lootName = lootName;
        this.dropChance = dropChance;
    }
}
