namespace FactoryDesignPattern
{
    using System;

    class FactoryPatternDemo
    {
        /*
         * За 'Factory' модела е характерно, че имаме един супер клас който определя стандартното поведение
         * (като използва placeholder-и за стъпките на създаване) и след това делегира детайлите по самото 
         * създаване на субкласове. Този модел прави дизайна по-лесен за промяна и само малко по-сложен.
         * Докато други дизайн модели изискват нови класове 'Factory' изисква нови операции. Често е използван
         * като стандартен метод за създаване на обекти, но не винаги е необходим, например когато класа, 
         * който се инстанциира никога не се променя. 'Factory' прилича на 'Abstract Factory', но без акцента
         * върху семейства от взаимосвързани и взаимозависими обекти, който е налице при втория модел.
         * 
         */
        static void Main(string[] args)
        {
            AircraftFactory factory = new Area51AircraftFactory();

            IFactory c130Hercules = factory.GetAircraft("PropellerAircraft");
            c130Hercules.Fly(100);

            IFactory f15Eagle = factory.GetAircraft("JetFighter");
            f15Eagle.Fly(1000);

        }
    }
}