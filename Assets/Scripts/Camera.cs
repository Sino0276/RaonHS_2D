using UnityEngine;


/***
 * 참고: https://www.youtube.com/watch?v=ZBj3LBA2vUY
 */
public class Camera : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 0, -10f);
    private Vector3 velocity = Vector3.zero;
    private Vector3 playerPosition;
    
    [SerializeField] private float smoothTime = 0.25f;
    [SerializeField] private Transform player;
    
    void Update()
    {
        playerPosition = player.position + offset;
        
    }

    void FixedUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, playerPosition, ref velocity, smoothTime);
    }
}
