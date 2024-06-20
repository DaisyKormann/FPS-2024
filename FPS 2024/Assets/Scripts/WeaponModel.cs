using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
[CreateAssetMenu(menuName = "Weapon")]

public class WeaponModel : ScriptableObject
{
<<<<<<< Updated upstream
    [SerializeField] float damage;
    [SerializeField] float range;
    public [SerializeField] float fireRate;
    [SerializeField] float spread;
    [SerializeField] float reloadTime;
    [SerializeField] float timeBetweenShoot;
    [SerializeField] int magazineCap;
    [SerializeField] int bulletsForShoot;
    [SerializeField] bool automatic;
    [SerializeField] bool scope;
    [SerializeField] Mesh model;
    [SerializeField] Material material;
    [SerializeField] Vector3 weaponPosition;

    public float Damage { get => damage;}
    public float Range { get => range; }
    public float FireRate { get => fireRate; }
    public float Spread { get => spread;}
    public float ReloadTime { get => reloadTime; }
    public float TimeBetweenShoot { get => timeBetweenShoot;  }
    public int MagazineCap { get => magazineCap;  }
    public int BulletsForShoot { get => bulletsForShoot;  }
    public bool Automatic { get => automatic;  }
    public bool Scope { get => scope; }
    public Mesh Model { get => model;  }
    public Material Material { get => material;  }
    public Vector3 WeaponPosition { get => weaponPosition;  }

    // Start is called before the first frame update
=======
    float damage;
    float range;
    float fireRate;
    float spread;
    float reloadTime;
    float timeBetweenShoot;
    int magazineCap;
    int bulletsForShoot;
    bool automatic;
    bool scope;
    Mesh model;
    Material material;
    Vector3 weaponPosition;

    public float Damage { get => damage;}
    public float Range { get => range;}
    public float FireRate { get => fireRate;}
    public float Spread { get => spread;}
    public float ReloadTime { get => reloadTime;  }
    public float TimeBetweenShoot { get => timeBetweenShoot;  }
    public int MagazineCap { get => magazineCap; }
    public int BulletsForShoot { get => bulletsForShoot;  }
    public bool Automatic { get => automatic;  }
    public bool Scope { get => scope;  }
    public Mesh Model { get => model;  }
    public Material Material { get => material;  }
    public Vector3 WeaponPosition { get => weaponPosition; }

>>>>>>> Stashed changes
    void Start()
    {
        
    }

<<<<<<< Updated upstream
    // Update is called once per frame
=======
>>>>>>> Stashed changes
    void Update()
    {
        
    }
}
