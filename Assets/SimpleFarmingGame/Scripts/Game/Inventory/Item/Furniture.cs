using System;
using UnityEngine;

namespace SimpleFarmingGame.Game
{
    [Serializable]
    public class SceneFurniture
    {
        public int FurnitureID;
        public SerializableVector3 Coordinate;
        public int BoxIndex;
    }

    public class Furniture : MonoBehaviour
    {
        public int ID;
    }
}