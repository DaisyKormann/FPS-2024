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

        currentMagazine = weaponModel.MagazineCap; // Inicialize o carregador atual com a capacidade m�xima do carregador da arma

       // Configure a apar�ncia da arma ja feito acima

    }

    void Update()
    {
        
    }
    void Fire()
    {
        StartCoroutine(FireCoroutine()); // chamar um m�todo
    }
    
    IEnumerator FireCoroutine()
    {
        // Verifica se pode disparar
        if (Time.time >= timeToShoot) // verificar muni��o e fire rate
        {

            // Define o tempo para o pr�ximo disparo
            timeToShoot = Time.time + 1 / weaponModel.FireRate;

            // Dispara proj�teis com o tempo entre cada disparo
            if (int i = 0; i < weaponModel.BulletsForShoot; i++)
            {
                if (currentMagazine > 0)
                {
                    // Reduz a muni��o do carregador
                    currentMagazine--;
                    Shoot();
                    yield return new WaitForSeconds(weaponModel.TimeBetweenShoot);
                }
            }

        }

    }

    private void Shoot()
    {
        // Vari�vel para armazenar o que foi atingido
        RaycastHit hit;

        // Dire��o do disparo, considerando a dispers�o da arma
        Vector3 dirction = new Vector3(Random.Range(-weaponModel.Spread, weaponModel.Spread), Random.Range(-weaponModel.Spread, weaponModel .Spread, 1));

        // Verifica se acertou algo na dire��o do disparo dentro do alcance
        if (Physics.Raycast(firePoint.position, out hit, weaponModel.Range))
        {

        }

        // Desenha uma linha para visualizar o trajeto do proj�til
    }

    void Reload()
    {
        StartCoroutine(ReloadCoroutine());
    }

    private IEnumerator ReloadCoroutine()
    { 
        // Verifica se precisa recarregar e se h� muni��o dispon�vel

        // Atualiza a muni��o no carregador e no invent�rio

        // Aguarda o tempo de recarga
    }

    private void OnDrawGizmos()
    {
        // Voc� pode adicionar gizmos para visualizar coisas como o alcance do disparo
        Gizmos.color = Color.red; // talvez ?
    }
}