using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private bool isDead = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (isDead) return;

            isDead = true;
            Debug.Log("ชนแล้ว!");
            GameManager.instance.GameOver();
        }
    }
}