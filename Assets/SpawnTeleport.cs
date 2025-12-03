using UnityEngine;

public class SpawnTeleport : MonoBehaviour
{
    public Transform Spawn; // Where the player will teleport to

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player touched the platform
        if (other.CompareTag("Player"))
        {
            other.transform.position = Spawn.position;
        }
    }
}