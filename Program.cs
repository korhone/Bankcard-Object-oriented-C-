using Maksukorttitehtava;


Bankcard pekkaCard = new Bankcard(20);
Bankcard mattiCard = new Bankcard(30);
Console.WriteLine("Pekka: " + pekkaCard);
Console.WriteLine("Matti: " + mattiCard);
pekkaCard.eatGood();
mattiCard.eatChep();
Console.WriteLine("Pekka: " + pekkaCard);
Console.WriteLine("Matti: " + mattiCard);
pekkaCard.LoadMoney(20);
mattiCard.eatGood();
Console.WriteLine("Pekka: " + pekkaCard);
Console.WriteLine("Matti: " + mattiCard);
pekkaCard.eatChep();
pekkaCard.eatChep();
mattiCard.LoadMoney(50);
Console.WriteLine("Pekka: " + pekkaCard);
Console.WriteLine("Matti: " + mattiCard);