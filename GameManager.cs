using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int playerHP = 20;
    public int enemyHP = 20;

    public int ether = 1;

    void Awake()
    {
        Instance = this;
    }

    public void DamageEnemy(int amount)
    {
        enemyHP -= amount;

        if(enemyHP <= 0)
        {
            Debug.Log("Player Wins");
        }
    }

    public void DamagePlayer(int amount)
    {
        playerHP -= amount;

        if(playerHP <= 0)
        {
            Debug.Log("Enemy Wins");
        }
    }
}
