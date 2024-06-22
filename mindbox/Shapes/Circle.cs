namespace mindbox.Shapes;
public class Circle : IShape
{
    private float m_radius;
    public float Radius
    {
        get => m_radius;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value, nameof(Radius));

            m_radius = value;
        }
    }

    public Circle(float radius)
    {
        Radius = radius;
    }

    public float GetArea()
    {
        return (float)(Math.PI * Math.Pow(m_radius, 2));
    }
}