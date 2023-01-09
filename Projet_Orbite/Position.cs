using System.Reflection;

namespace Projet_Orbite;

/** position:
 *       -a une valeur x et y correspondant a la position dans l'espace.
 *       -a une fonction affichePosition, qui return les données x et y dans une string sous cette
 *           forme:
 *           position:   x:%x%km
 *                       y:%y%km
 */

public class Position
{
    private float x;
    private float y;

    // Constructeur par default
    public Position()
    {
        this.x = 0;
        this.y = 0;
    }
    
    // Constructeur statique
    public Position(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    // Getter de x
    public float getX()
    {
        return x;
    }    
    
    // Setter de x
    public void setX(float newValue)
    {
        x = newValue;
    }
    
    // Getter de y
    public float getY()
    {
        return y;
    }
    
    // Setter de y
    public void setY(float newValue)
    {
        y = newValue;
    }

    // Renvoi un string avec les valeurs x et y 
    string affichePosition()
    {
        return x + "km" + "\n" + y + "km";
    }
}