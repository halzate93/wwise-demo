using CotA.Sound;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private SoundManager soundManager;
    [SerializeField] private int startingHealth = 100;
    [SerializeField] private int damagePerHit = 5;

    private int currentHealth;

    private void Start()
    {
        currentHealth = startingHealth;
    } 


    private void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            Debug.Log ("Hit");
            currentHealth -= damagePerHit;
            soundManager.OnPlayerDamage (currentHealth / (float)startingHealth);
        }
    } 
}
