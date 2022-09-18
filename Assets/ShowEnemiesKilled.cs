using UnityEngine;
using TMPro;

public class ShowEnemiesKilled : MonoBehaviour
{
    public EnemyCounter enemyValues;

    public TextMeshProUGUI textDisplay;

    private void Update()
    {

        textDisplay.text = ("Enemies Killed: " + enemyValues.EnemiesKilled.ToString());
    }
}
