using UnityEngine;

public class LaneManager : MonoBehaviour
{
    public CardUnit unit;

    public bool IsEmpty()
    {
        return unit == null;
    }

    public void Place(CardUnit newUnit)
    {
        unit = newUnit;
        newUnit.transform.position = transform.position;
    }

    public void Remove()
    {
        unit = null;
    }
}
