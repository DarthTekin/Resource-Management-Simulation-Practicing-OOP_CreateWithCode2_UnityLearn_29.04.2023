using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductivityUnit : Unit
{
    private ResourcePile m_CurrentPile = null;
    public float ProductivityMultiplyer = 2;

    protected override void BuildingInRange()
    {

    }
}
