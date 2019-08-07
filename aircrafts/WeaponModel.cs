
public class WeaponModel{

    public string WeaponName;
    public int DealingDamage;
    public int FireRate;
    public int OverallAmmo;
    public string Color;

    public WeaponModel(string weaponName, int damage, int fireRate, int ammo, string color) {
        this.WeaponName = weaponName;
        this.DealingDamage = damage;
        this.FireRate = fireRate;
        this.OverallAmmo = ammo;
        this.Color = color;
    }

}