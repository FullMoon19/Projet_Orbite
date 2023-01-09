namespace Projet_Orbite;

public class Objet
{
    private Position position;
    private float poids;

    
    // Constructeur par default 
    public Objet()
    {
        this.position = new Position();
        this.poids = 0;
    }
    
    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="position"> Position de l'objet </param>
    /// <param name="poids"> Poids de l'objet </param>
    public Objet(Position position, float poids)
    {
        this.position = position;
        this.poids = poids;
    }

    // Getter de position
    public Position getPosition()
    {
        return position;
    }
    
    // Setter de position
    protected void setPosition(Position newPosition)
    {
        position = newPosition;
    }
    
    // Getter de poids
    public float getPoids()
    {
        return poids;
    }
    
    // Setter de poids
    public void setPoids(float newPoids)
    {
        poids = newPoids;
    }
    
}