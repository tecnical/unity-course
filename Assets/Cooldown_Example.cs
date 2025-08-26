using UnityEngine;

public class Cooldown_Example : MonoBehaviour
{
    private SpriteRenderer sr;

    [SerializeField] private float redColorDuration = 1;

    public float currentTimeInGame;
    public float lastTimeWasDamaged;

    public void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        currentTimeInGame = Time.time;
        if (currentTimeInGame > lastTimeWasDamaged + redColorDuration)
        {
            if (sr.color != Color.white)
            {
                TurnWhite();
            }
        }
    }


    public void TakeDamage()
    {
        sr.color = Color.red;
        lastTimeWasDamaged = Time.time;
    }

    private void TurnWhite()
    {
        sr.color = Color.white;
    }
}
