using UnityEngine;

[CreateAssetMenu(fileName ="EnemyCounter", menuName ="ScriptableOjects/EnemyCounter")]
public class EnemyCounter : ScriptableObject
{
    public int EnemiesKilled;

    private void OnEnable()
    {
        EnemiesKilled = 0;
    }
}
