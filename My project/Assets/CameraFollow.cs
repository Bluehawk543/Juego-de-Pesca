using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player; // Reference to the player's transform
    [SerializeField] private float smoothSpeed = 5f; // Smoothness of camera movement
    [SerializeField] private Vector2 offset; // Offset for X and Y

    private void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
        }
    }
}