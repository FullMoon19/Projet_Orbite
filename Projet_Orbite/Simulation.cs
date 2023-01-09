namespace Projet_Orbite;

public class Simulation
{
    /// <summary>
    /// 
    /// </summary>
    private Planete planete;

    /// <summary>
    /// 
    /// </summary>
    private Objet objet;
    /// <summary>
    /// Angle de lancer
    /// </summary>
    private float angleInDegrees;
    /// <summary>
    /// Vitesse (m/s)
    /// </summary>
    private float speed;
    
    public Simulation(Planete planete, Objet objet, float angleInDegrees, float speed)
    {
        this.planete = planete;
        this.objet = objet;
        this.angleInDegrees = angleInDegrees;
        this.speed = speed;
    }
    
    
    public void startSimulation()
    {
    }
    
}