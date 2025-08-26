using UnityEngine;

public class Enemy_Goblin : Enemy
{
    private void StealMoney()
    {
        Debug.Log(enemyName + " is stealing money!");
    }

    protected override void Attack()
    {
        base.Attack();
        StealMoney();
    }


}
