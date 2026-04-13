internal class Program
{
    private static void Main(string[] args)
    {
        cars Car1 = new cars();
        cars Car2 = new cars("Шевроле Нива", 10, 60, 434, 256);
        cars Car3 = new cars("Бугатти Вейрон", 32, 70);

        Car1.showCar();
        Car2.showCar();
        Car3.showCar();

        Car1.compare(Car2);
        Car1.compare(Car3);
        Car2.compare(Car3);

        Car1.fuelling(74);
        Car1.compare(Car3);

        Car1.moveTo(243, 128);
        Car1.showCar();
    }
}