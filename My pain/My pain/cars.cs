// Класс машин с 3 методами

public class cars
{
    // Поля (Слагаемое 1, Слагаемое 2, знак действия)
    private string model;
    private int speed;
    private int fuel;
    private int pos_x;
    private int pos_y;

    // Констукторы
    // По умолчанию (базовый, без параметра)
    public cars()
    {
        this.model = "Лада Седан";
        this.speed = 4;
        this.fuel = 35;
        this.pos_x = 0;
        this.pos_y = 0;
    }

    // С параметрами
    public cars(string model, int speed, int fuel, int pos_x, int pos_y)
    {
        this.model = model;
        this.speed = speed;
        this.fuel = fuel;
        this.pos_x = pos_x;
        this.pos_y = pos_y;
    }
    
    public cars(string model, int speed, int fuel)
    {
        this.model = model;
        this.speed = speed;
        this.fuel = fuel;
        this.pos_x = 0;
        this.pos_y = 0;
    }

    // Копирование
    public cars(cars Cars)
    {
        this.model = Cars.model;
        this.fuel = Cars.fuel;
        this.speed = Cars.speed;
        this.pos_x = Cars.pos_x;
        this.pos_y = Cars.pos_y;
    }

    // Свойства
    public string Model
    {
        get { return model; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public int Fuel
    {
        get { return fuel; }
        set { fuel = value; }
    }

    public int Pos_x
    {
        get { return pos_x; }
        set { pos_x = value; }
    }

    public int Pos_y
    {
        get { return pos_y; }
        set { pos_y = value; }
    }

    // Методы
    public void compare(cars Car2)
    {
        if (this.speed > Car2.speed)
        {
            Console.WriteLine(this.model + " быстрее чем " + Car2.model);
        }
        else
        {
            Console.WriteLine(Car2.model + " быстрее чем " + this.model);
        }

        if (this.fuel > Car2.fuel)
        {
            Console.WriteLine("У " + this.model + " топлива больше чем у " + Car2.model);
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine("У " + Car2.model + " топлива больше чем у " + this.model);
            Console.WriteLine(" ");
        }
    }

    public void moveTo(int pos_x, int pos_y)
    {
        this.pos_x = pos_x;
        this.pos_y = pos_y;
    }

    public void fuelling(int fuel)
    {
        this.fuel = fuel;
    }

    public void showCar()
    {
        Console.WriteLine("Модель автомобиля: " + this.Model);
        Console.WriteLine("Скорость автомобиля: " + this.Speed);
        Console.WriteLine("Вместимость топливного бака: " + this.Fuel);
        if (this.pos_x != 0)
        {
            Console.WriteLine("Позиция автомобиля по оси X: " + this.pos_x);
        }
        else
        {
            Console.WriteLine("Автомобиль стоит на нуле по оси X");
        }
        if (this.pos_y != 0)
        {
            Console.WriteLine("Позиция автомобиля по оси Y: " + this.pos_y);
        }
        else
        {
            Console.WriteLine("Автомобиль стоит на нуле по оси Y");
        }
        Console.WriteLine(" ");
    }
}