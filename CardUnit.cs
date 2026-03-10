using UnityEngine;

public class CardUnit : MonoBehaviour
{
    public int atk;
    public int hp;

    public string cardName;

    public void Init(CardData data)
    {
        cardName = data.name;
        atk = data.atk;
        hp = data.hp;
    }
}
