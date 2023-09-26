// implementing the fraction class.

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Setting the default values for top and bottom to 1 and 1.
        _top = 1;
        _bottom = 1;   
    }

    public Fraction(int aTopWholenumber)
    {
        //Setting the bottom to a default value of 1 and
        // and creating a parameter to enter the top value
        _top = aTopWholenumber;
        _bottom = 1;
    }

    public Fraction(int aTop, int aBottom)
    {

        // Creating a parameter for both the top and the bottom 
        // to enter their values
        _top = aTop;
        _bottom = aBottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double) _top/(double) _bottom;
    }

}