using UnityEngine;

public class TeleportPlatform : MonoBehaviour
{
    public Transform teleportDestination; // Where the player will teleport to

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player touched the platform
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleportDestination.position;
        }
    }
}