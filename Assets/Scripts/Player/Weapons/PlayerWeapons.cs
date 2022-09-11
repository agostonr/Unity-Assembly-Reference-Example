using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    // FIXME reference the demo.Gameplay assembly in demo.Player to fix the issue
    
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
            Shoot();
        }
    }

    private void Shoot()
    {
        // code that makes the player shoot
    }
}
