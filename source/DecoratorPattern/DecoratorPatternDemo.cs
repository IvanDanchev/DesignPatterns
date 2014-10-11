namespace DecoratorPattern
{
    using System;

    /* Дизайн моделът 'Decorator' позволява да се добави допълнителна функционалност
     * към обекта и това да става динамично, без да е необходимо създаването на верига
     * от наследяване. Целта е да се добави поведение или състояние на обекта при 'run-time',  
     * а не той да се изменя статично. В този смисъл 'Decorator' се явява алтернатива на  
     * добавянето на функционалност чрез създаване на множество субкласове.
     * 
     */
    class DecoratorPatternDemo
    {
        static void Main(string[] args)
        {
            // Base rifle
            AssaultRifle rifle = new SteyrAugRifle();

            Console.WriteLine("Base {0} {1} rifle data: price {2:c}; weight {3} kg.", rifle.Make, rifle.Model, rifle.Price, rifle.Weight);
            Console.WriteLine();

            // Custom rifle offer
            CustomAssaultRifleOffer offer = new CustomAssaultRifleOffer(rifle);
            offer.AttachmentsPrice = 400;
            offer.AttachmentsWeight = 0.4;

            Console.WriteLine("Rifle + 6xMagnificationScope offer data: price {0:c}; weight {1} kg.", offer.Price, offer.Weight);
            Console.WriteLine();

            // Custom paint
            RifleCustomPaint paint = new RifleCustomPaint(rifle);
            paint.AddCustomPaint("Forest Green");
            Console.WriteLine();

            // Custom rifle + custom paint
            RifleCustomPaint paintAndAttachments = new RifleCustomPaint(offer);
            paintAndAttachments.AddCustomPaint("Dark Grey");
            Console.WriteLine();
        }
    }
}
