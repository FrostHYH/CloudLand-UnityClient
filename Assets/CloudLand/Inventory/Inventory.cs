﻿using UnityEngine;
using Org.Dragonet.Cloudland.Net.Protocol;

public abstract class Inventory : MonoBehaviour {
    public SerializedItem[] items;

    public static Texture2D getItemTexture(int id, int meta)
    {
        return (Texture2D)Resources.Load("Images/Items/" + id + "_" + meta);
    }
}
