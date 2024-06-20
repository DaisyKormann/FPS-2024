<<<<<<< Updated upstream
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.XR;

public class Weapon : MonoBehaviour
{
    [SerializeField] WeaponModel weaponModel;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletImpact;

     MeshFilter meshFilter;
    MeshRenderer meshRenderer;

    int currentMagazine;

    float timeToShoot;

    void Start()
    {

        meshFilter = GetComponentInChildren<MeshFilter>();
        meshRenderer = GetComponentInChildren<MeshRenderer>();

        currentMagazine = weaponModel.MagazineCap; // Inicialize o carregador atual com a capacidade máxima do carregador da arma

       // Configure a aparência da arma ja feito acima

    }

    void Update()
    {
        
    }
    void Fire()
    {
        StartCoroutine(FireCoroutine()); // chamar um método
    }
    
    IEnumerator FireCoroutine()
    {
        // Verifica se pode disparar
        if (Time.time >= timeToShoot) // verificar munição e fire rate
        {

            // Define o tempo para o próximo disparo
            timeToShoot = Time.time + 1 / weaponModel.FireRate;

            // Dispara projéteis com o tempo entre cada disparo
            if (int i = 0; i < weaponModel.BulletsForShoot; i++)
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] WeaponModel weaponData;
    [SerializeField] GameObject bulletImpact;
    [SerializeField] Transform firePoint;

    MeshFilter meshFilter;

    MeshRenderer meshRenderer;

    int currentMagazine;
    int ammo;
    float timeToShoot;
    bool reloading;

    // Start is called before the first frame update
    void Start()
    {
        meshFilter = GetComponentInChildren<MeshFilter>();
        meshRenderer = GetComponentInChildren<MeshRenderer>();

        UpdateWeapon(weaponData);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    public void Fire(bool crouching)
    {
        StartCoroutine(FireCoroutine(crouching));
    }

    IEnumerator FireCoroutine(bool crouching)
    {
        // Verifica se pode disparar
        if (Time.time >= timeToShoot && !reloading)
        {
            // Define o tempo para o próximo disparo
            timeToShoot = Time.time + 1 / weaponData.FireRate;

            // Dispara projéteis com o tempo entre cada disparo
            for (int i = 0; i < weaponData.BulletsForShoot; i++)
>>>>>>> Stashed changes
            {
                if (currentMagazine > 0)
                {
                    // Reduz a munição do carregador
                    currentMagazine--;
                    Shoot();
<<<<<<< Updated upstream
                    yield return new WaitForSeconds(weaponModel.TimeBetweenShoot);
                }
            }

        }

    }

    private void Shoot()
    {
        // Variável para armazenar o que foi atingido
        RaycastHit hit;

        // Direção do disparo, considerando a dispersão da arma
        Vector3 dirction = new Vector3(Random.Range(-weaponModel.Spread, weaponModel.Spread), Random.Range(-weaponModel.Spread, weaponModel .Spread, 1));

        // Verifica se acertou algo na direção do disparo dentro do alcance
        if (Physics.Raycast(firePoint.position, out hit, weaponModel.Range))
        {

        }

        // Desenha uma linha para visualizar o trajeto do projétil
=======
                    yield return new WaitForSeconds(weaponData.TimeBetweenShoot);
                }
            }
        }
    }

    void Shoot()
    {
        // Variável para armazenar o que foi atingido
        RaycastHit hit;
        // Direção do disparo, considerando a dispersão da arma
        Vector3 direction = firePoint.forward + new Vector3(Random.Range(-weaponData.Spread, weaponData.Spread), Random.Range(-weaponData.Spread, weaponData.Spread), 0);
        // Verifica se acertou algo na direção do disparo dentro do alcance
        if (Physics.Raycast(firePoint.position, direction, out hit, weaponData.Range))
        {
            Instantiate(bulletImpact, hit.point, Quaternion.identity);
            // Desenha uma linha para visualizar o trajeto do projétil
            Debug.DrawLine(firePoint.position, direction * weaponData.Range);
        }
>>>>>>> Stashed changes
    }

    void Reload()
    {
        StartCoroutine(ReloadCoroutine());
    }

    private IEnumerator ReloadCoroutine()
<<<<<<< Updated upstream
    { 
        // Verifica se precisa recarregar e se há munição disponível

        // Atualiza a munição no carregador e no inventário

        // Aguarda o tempo de recarga
    }

    private void OnDrawGizmos()
    {
        // Você pode adicionar gizmos para visualizar coisas como o alcance do disparo
        Gizmos.color = Color.red; // talvez ?
=======
    {
        // Verifica se precisa recarregar e se há munição disponível
        if (currentMagazine < weaponData.MagazineCap && ammo > 0)
        {
            // Atualiza a munição no carregador e no inventário
            if (currentMagazine + ammo >= weaponData.MagazineCap)
            {
                ammo -= weaponData.MagazineCap - currentMagazine;
                currentMagazine = weaponData.MagazineCap;
            }
            else
            {
                currentMagazine += ammo;
                ammo = 0;
            }
            // Aguarda o tempo de recarga
            reloading = true;
            yield return new WaitForSeconds(weaponData.ReloadTime);
            reloading = false;
        }
    }

    void UpdateWeapon(WeaponModel newWeapon)
    {
        weaponData = newWeapon;
        meshFilter.mesh = weaponData.Model;
        meshRenderer.material = weaponData.Material;

        currentMagazine = weaponData.MagazineCap;
>>>>>>> Stashed changes
    }
}