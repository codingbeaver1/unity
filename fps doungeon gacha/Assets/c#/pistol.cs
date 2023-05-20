using UnityEngine;
using System.Collections;

public class pistol : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    private int maxAmmo = 20;
    private int currentAmmo;
    public float reloadtime = 2f;
    private bool isreloding = false;

    void Start()
    {
        currentAmmo = maxAmmo;
    }


    void Update ()
    {
        if (isreloding)
        {
            return;
        }

        if (currentAmmo <= 0)
        {
            StartCoroutine(reload());
            return;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            currentAmmo--;
            shoot();
            

        }
    }
    IEnumerator reload()
    {
        isreloding = true;
        Debug.Log("reloding....");
        yield return new WaitForSeconds(reloadtime);
        currentAmmo = maxAmmo;
        isreloding = false;
    }

    void shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            enemy target = hit.transform.GetComponent<enemy>();
            if (target != null)
            {
                target.TakeDamage(damage);
                
            }


            enemyhealth DamageEnemy = hit.transform.GetComponent<enemyhealth>();
            if (DamageEnemy != null)
            {
                
                DamageEnemy.GetComponent<enemyhealth>().EnemyTakesDamage(damage);
            }


        }

    }

}
