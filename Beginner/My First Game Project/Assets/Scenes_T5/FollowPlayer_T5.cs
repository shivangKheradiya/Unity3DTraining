using UnityEngine;

public class FollowPlayer_T5 : MonoBehaviour
{
    public Transform PlayerTransform;
    public Vector3 offset;

    private void Update()
    {
        transform.position = PlayerTransform.position + offset;
    }
}
