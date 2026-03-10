using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public bool playerTurn = true;

    public void EndTurn()
    {
        playerTurn = !playerTurn;

        GameManager.Instance.ether++;

        if(playerTurn)
        {
            Debug.Log("Player Turn");
        }
        else
        {
            Debug.Log("Enemy Turn");
        }
    }
}
