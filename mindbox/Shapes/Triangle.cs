namespace mindbox.Shapes;
public class Triangle : IShape
{
    private float m_sideA;
    private float m_sideB;
    private float m_sideC;

    public float SideA
    {
        get => m_sideA;
    }

    public float SideB
    {
        get => m_sideB;
    }

    public float SideC
    {
        get => m_sideC;
    }

    public Triangle(float sideA, float sideB, float sideC)
    {
        SetSides(sideA, sideB, sideC);
    }

    public void SetSides(float sideA, float sideB, float sideC)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(sideA, nameof(sideA));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(sideB, nameof(sideB));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(sideC, nameof(sideC));

        if (!isValidTriangle(sideA, sideB, sideC))
        {
            throw new ArgumentException("Triangle is not exist!");
        }

        m_sideA = sideA;
        m_sideB = sideB;
        m_sideC = sideC;
    }

    public float GetArea()
    {
        float halfPerimeter = (m_sideA + m_sideB + m_sideC) / 2;
        return (float)Math.Sqrt(halfPerimeter * (halfPerimeter - m_sideA) * (halfPerimeter - m_sideB) * (halfPerimeter - m_sideC));
    }

    private static bool isValidTriangle(float sideA, float sideB, float sideC)
    {
        return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }

    public bool IsRight()
    {
        float[] triangleSides = [m_sideA, m_sideB, m_sideC];
        Array.Sort(triangleSides);
        return triangleSides[0] * triangleSides[0] + triangleSides[1] * triangleSides[1] == triangleSides[2] * triangleSides[2];
    }
}