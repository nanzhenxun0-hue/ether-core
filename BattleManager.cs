using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public LaneManager[] playerLanes;
    public LaneManager[] enemyLanes;

    public void ResolveBattle()
    {
        for(int i = 0; i < 3; i++)
        {
            CardUnit player = playerLanes[i].unit;
            CardUnit enemy = enemyLanes[i].unit;

            if(player != null && enemy != null)
            {
                Combat(player, enemy);
            }
            else if(player != null && enemy == null)
            {
                DirectAttack(player);
            }
            else if(enemy != null && player == null)
            {
                EnemyDirect(enemy);
            }
        }
    }

    void Combat(CardUnit a, CardUnit b)
    {
        b.hp -= a.atk;
        a.hp -= b.atk;

        if(b.hp <= 0)
            Destroy(b.gameObject);

        if(a.hp <= 0)
            Destroy(a.gameObject);
    }

    void DirectAttack(CardUnit attacker)
    {
        GameManager.Instance.DamageEnemy(attacker.atk);
    }

    void EnemyDirect(CardUnit attacker)
    {
        GameManager.Instance.DamagePlayer(attacker.atk);
    }
}
