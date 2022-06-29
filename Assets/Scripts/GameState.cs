using UnityEngine;

public class GameState : MonoBehaviour
{
    private bool _isPlayerAlive = true;

    public void KillPlayer()
    {
        _isPlayerAlive = false;
    }

    public bool IsPlayerAlive()
    {
        return _isPlayerAlive;
    }
}
