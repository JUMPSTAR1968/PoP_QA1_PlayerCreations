using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI m_Text;
    private int Health = 2006;
    private int Mana = 1024;
    private int PhysicalDamage = 512;
    private int MagicalDamage = 256;
    private int Armor = 512;
    private int MagicResistance = 128;
    private float Speed = 158.3f;

    public void ButtonPressed()
    {
        m_Text.text = $"Name: Jedidiah Lopez \n Health: {Health} \n Mana: {Mana} \n Physical Damage: {PhysicalDamage} \n Magical Damage: {MagicalDamage} \n Armor: {Armor} \n Magic Resistance: {MagicResistance} \n Speed: {Speed}";
    }

}
