using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 10, -8);

    void LateUpdate()
    {
        Quaternion rotation = Quaternion.Euler(0, target.eulerAngles.y, 0);
        Vector3 rotatedOffset = rotation * offset;

        transform.position = target.position + rotatedOffset;

        // ⭐ เงยมุมขึ้น
        transform.LookAt(target.position + Vector3.up * 2f);
    }
}