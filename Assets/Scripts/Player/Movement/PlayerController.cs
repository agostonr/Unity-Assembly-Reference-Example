using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // code from our project, from another assembly
    private GameplayManager gameplayManager;

    void Start()
    {
        gameplayManager = GameObject.Find("GameController").GetComponent<GameplayManager>();
    }

    void Update()
    {
        if (gameplayManager.IsControlsEnabled)
        {
            MovePlayer();
        }
    }

    private void MovePlayer()
    {
        // code that moves the player
    }
}
