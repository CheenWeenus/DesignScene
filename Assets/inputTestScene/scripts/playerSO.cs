using UnityEngine;

[CreateAssetMenu(fileName = "playerSO", menuName = "player stats")]
public class playerSO : ScriptableObject {
    public int bulletCount = 3;
    public float bulletSpeed = 100;
    public float moveSpeed = 5;
}
