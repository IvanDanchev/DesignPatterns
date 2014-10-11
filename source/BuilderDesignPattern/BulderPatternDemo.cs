namespace BuilderDesignPattern
{
    using System;

    /* 'Bulder' е креационен дизайн модел и се използва за контрол на инстанцирането на класове. 
     * Той позволява да се създават комплексни обекти със съставни части, които трябва да се създадат
     * в определен ред или използвайки даден алгоритъм. Един външен клас, исвестен като 'Режисьор', 
     * контролира реда на създаване. В реалния свят често съставните части също са комплексни обекти.
     * В нашия пример ще използваме 2 'Bulder'-а, които ще създават списък от данни (в определен ред) 
     * за 2 типа крилати ракети: Tomahawk и JASSM.
     */
    class BulderPatternDemo
    {
        static void Main(string[] args)
        {
            MissileDirector director = new MissileDirector();
            MissileBuilder builder = new LockheedMartinMissileBuilder();
            director.CreateMissile(builder);
            CruiseMissile jassmMissile = builder.BuildMissile();

            Console.WriteLine(jassmMissile);
            Console.WriteLine();

            MissileBuilder builder2 = new RaytheonMissileBuilder();
            director.CreateMissile(builder2);
            CruiseMissile tomahawk = builder2.BuildMissile();

            Console.WriteLine(tomahawk);
            Console.WriteLine();
        }
    }
}
