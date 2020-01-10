using Godot;
using System;

public static class Player
{
    public static float energyMax = 100.0f;
    public static float energy = 100.0f;

    public static void AddEnergy(float amount)
    {
        energy += amount;
        if (energy>energyMax)
            energy = energyMax;
    }

    public static void RemoveEnergy(float amount)
    {
        energy -= amount;
        if (energy<0)
            energy = 0;
    }

    public static void PrintEnergy(){
        GD.Print("Le Joueur a " + energy + "/" + energyMax + ".");
    }
}
