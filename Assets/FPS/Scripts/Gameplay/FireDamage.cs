using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Game
{
    public class FireDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public float damage = 1f;

    void OnTriggerStay(Collider collider){
        collider.GetComponent<Damageable>().InflictDamage(damage, false, null);
    }
}

}