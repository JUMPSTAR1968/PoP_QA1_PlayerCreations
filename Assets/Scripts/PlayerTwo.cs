using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
    private int Health = 2002;
    private int Mana = 1000;
    private int PhysicalDamage = 316;
    private int MagicalDamage = 256;
    private int Armor = 458;
    private int MagicResistance = 150;
    private float Speed = 200.2f;

    public void ButtonPressed()
    {
        m_Text.text = $"Name: Akane Kurokawa \n Health: {Health} \n Mana: {Mana} \n Physical Damage: {PhysicalDamage} \n Magical Damage: {MagicalDamage} \n Armor: {Armor} \n Magic Resistance: {MagicResistance} \n Speed: {Speed}";
    }
}
