using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerThree : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI m_Text;
    private int Health = 1997;
    private int Mana = 1997;
    private int PhysicalDamage = 1000;
    private int MagicalDamage = 734;
    private int Armor = 800;
    private int MagicResistance = 672;
    private float Speed = 199.7f;

    public void ButtonPressed()
    {
        m_Text.text = $"Name: Yuffie Kisaragi \n Health: {Health} \n Mana: {Mana} \n Physical Damage: {PhysicalDamage} \n Magical Damage: {MagicalDamage} \n Armor: {Armor} \n Magic Resistance: {MagicResistance} \n Speed: {Speed}";
    }
}
