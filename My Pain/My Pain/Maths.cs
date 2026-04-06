// Класс с 3 мат функциями над натуральными числами

public class Maths
{
    // Поля (Слагаемое 1, Слагаемое 2, знак действия)
    private int num1;
    private int num2;
    private char sign;

    // Констукторы
    // По умолчанию (базовый, без параметра)
    public Maths()
    {
        if (num1 > 0)
        {
            num1 = 0;
            num2 = 0;
            sign = '+';
        }
        else
        {
            // Ошибка
        }
    }

    // С параметрами
    public Maths(int num1, int num2, char sign)
    {
        if (num1 > 0)
        {
            this.num1 = num1;
        }
        else
        {
            // Ошибка
        }

        if (num2 > 0)
        {
            this.num2 = num2;
        }
        else
        {
            // Ошибка
        }

        this.sign = sign;
    }
    
    public Maths( char sign, int num1, int num2)
    {
        this.sign = sign;
        this.num1 = num1;
        this.num2 = num2;
    }

    // Копирование
    public Maths(Maths maths)
    {
        this.num1 = maths.num1;
        this.num2 = maths.num2;
        this.sign = maths.sign;
    }

    // Свойства
    public char Sign
    {
        get { return sign; }
        set { sign = value; }
    }

    public int Num1
    {
        get { return num1; }
        private.set
        {
               
        }
}

    public int Num2
    {
        set { num2 = value; }
    }

    // Методы
    public int Calc()
    {
        if (sign == '+')
        {
            return num1 + num2;
        }
        else if (sign == '-')
        {
            return num1 - num2;
        }
        else if (sign == '*')
        {
            return num1 * num2;
        }
        else
        {
            return -1;
        }
    }

    public override string ToString()
    {
        return num1 + " " +  sign + " " + num2; 
    }

}