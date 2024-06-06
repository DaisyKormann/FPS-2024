using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] WeaponModel weapon;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletImpact;
    [SerializeField] int magazine;


    void Start()
    {

        GetComponentInChildren<MeshFilter>();
        GetComponentInChildren<MeshRenderer>();

        magazine = weapon.MagazineCap; // Inicialize o carregador atual com a capacidade m�xima do carregador da arma

       //? Configure a apar�ncia da arma 

    }

    void Update()
    {
        
    }
    void Fire()
    {
        StartCoroutine("Disparo Arma");
    }
    
    private IEnumerator FireCoroutine()
    {

        if () // Verifica se pode disparar
        {
            magazine--;         // Reduz a muni��o do carregador
            weapon.FireRate = 7;         // Define o tempo para o pr�ximo disparo

        }



        // Dispara proj�teis com o tempo entre cada disparo

    }

    private void Shoot()
    {
        // Vari�vel para armazenar o que foi atingido
        // Dire��o do disparo, considerando a dispers�o da arma

        // Verifica se acertou algo na dire��o do disparo dentro do alcance

        // Desenha uma linha para visualizar o trajeto do proj�til
    }

    void Reload()
    {
        StartCoroutine("Recarga");
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