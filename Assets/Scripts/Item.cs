using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SST
{
    public class Item : ScriptableObject
    {
        [Header("Item Information")]
        public Sprite itemIcon;
        public string itemName;
    }
}