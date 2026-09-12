using UnityEngine;

namespace Assignment.StudentSolution
{
    public class OOPTest : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("===== HOMEWORK OOP TEST START =====");

            // Player
            Player player = new Player();
            player.name = "Player";

            // Enemies
            Troll troll = new Troll();
            troll.name = "Troll";

            Orc orc = new Orc();
            orc.name = "Orc";

            Archer archer = new Archer();
            archer.name = "Archer";

            Mage mage = new Mage();
            mage.name = "Mage";

            // NPC
            NPC npc = new NPC();
            npc.name = "NPC";
            npc.dialogue = "Hello Player!";

            // Potion
            Potion potion = new Potion();
            potion.name = "Health Potion";
            potion.healingAmount = 50;

            // Sword
            Sword sword = new Sword();
            sword.name = "Iron Sword";
            sword.attackPower = 20;

            // Bow
            Bow bow = new Bow();
            bow.name = "Wooden Bow";
            bow.attackPower = 15;

            // Staff
            Staff staff = new Staff();
            staff.name = "Magic Staff";
            staff.attackPower = 25;

            // Armor
            Armor armor = new Armor();
            armor.name = "Iron Armor";
            armor.defense = 10;

            Debug.Log("----- Enemy Test -----");

            troll.Attack(player);
            troll.Regenerate();

            orc.Attack(player);
            orc.Enrage();

            archer.Attack(player);
            archer.AimAndShoot(player);

            mage.Attack(player);
            mage.CastSpell(player);

            Debug.Log("----- NPC Test -----");

            npc.Interact(player);

            Debug.Log("----- Item Test -----");

            potion.Use(player);

            Debug.Log("----- Equipment Test -----");

            sword.Equip(player);
            sword.Slash();
            sword.DealDamage(troll);

            bow.Equip(player);
            bow.Shoot();
            bow.DealDamage(troll);

            staff.Equip(player);
            staff.CastSpell();
            staff.DealDamage(troll);

            armor.Equip(player);

            Debug.Log("===== HOMEWORK OOP TEST END =====");
        }
    }
}