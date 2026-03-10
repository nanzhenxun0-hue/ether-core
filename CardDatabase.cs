using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class CardDatabase : MonoBehaviour
{
    public List<CardData> cards = new List<CardData>();

    void Start()
    {
        LoadCards();
    }

    void LoadCards()
    {
        string path = Application.dataPath + "/Resources/cards.json";

        string json = File.ReadAllText(path);

        cards = JsonUtility.FromJson<CardList>(json).cards;
    }
}

[System.Serializable]
public class CardList
{
    public List<CardData> cards;
}
