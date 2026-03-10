using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text nameText;
    public Text atkText;
    public Text hpText;
    public Text costText;

    public void Setup(CardData card)
    {
        nameText.text = card.name;
        atkText.text = card.atk.ToString();
        hpText.text = card.hp.ToString();
        costText.text = card.cost.ToString();
    }
}
