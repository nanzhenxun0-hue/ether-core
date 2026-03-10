using UnityEngine;

public class BattleFlow : MonoBehaviour
{
    public BattleManager battleManager;

    public void EndTurn()
    {
        battleManager.ResolveBattle();
    }
}
