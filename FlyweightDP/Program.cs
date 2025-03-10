using FlyweightDP;

CharacterFactory factory = new CharacterFactory();

// Get shared instances of characters
ICharacter charA1 = factory.GetCharacter('A');
ICharacter charA2 = factory.GetCharacter('A'); // Reuses existing 'A'
ICharacter charB = factory.GetCharacter('B');

// Display with different extrinsic states
charA1.Display(12, "Red");
charA2.Display(14, "Blue");
charB.Display(16, "Green");

// Verify that 'A' is reused
Console.WriteLine($"charA1 and charA2 are same object: {charA1 == charA2}");