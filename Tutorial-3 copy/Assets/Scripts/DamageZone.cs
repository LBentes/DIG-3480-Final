using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public RubyController player;
    public float speedDamage = 1.0f;
    public float speedOriginal = 3.0f;
    private IEnumerator speedChange;
    //public RubySpeed = GameObject.Find("Ruby").GetComponent<RubyController>().speed;
        void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController >();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
            //ChangeDamageSpeed();
            speedChange = ChangeDamageSpeed();
            StartCoroutine(speedChange);
        }
    }
    IEnumerator ChangeDamageSpeed()
    {
        player.speed = speedDamage;
        yield return new WaitForSeconds(2.0f);
        player.speed = speedOriginal;
    }
}
