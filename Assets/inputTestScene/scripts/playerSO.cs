using UnityEngine;

[CreateAssetMenu(fileName = "playerSO", menuName = "player stats")]
public class playerSO : ScriptableObject {
    public int maxBulletCount = 3;
    public int bulletCount = 3;
    public float bulletSpeed = 100;
    public float moveSpeed = 5;
    public float reloadTime = 2;
}
