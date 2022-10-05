using IntroEntityFramework.Models;

Console.WriteLine("Hello, World!");

SystemContext context = new SystemContext();

context.Database.EnsureCreated();

// Create (INSERT)
// Computer c1 = new Computer(1, "2GB", "13");
// context.Computers.Add(c1);
// context.SaveChanges();

// Computer c2 = new Computer(2, "6GB", "i5");
// context.Computers.Add(c2);
// context.SaveChanges();

// Computer c3 = new Computer(3, "16GB", "i7");
// context.Computers.Add(c3);
// context.SaveChanges();

// Read (SELECT)
IEnumerable<Computer> computers = context.Computers.ToList();
foreach (var comp in computers)
{
    Console.WriteLine($"{comp.Id}, {comp.Ram}, {comp.Processor}");
}

// Read (SELECT)
Computer encontrado = context.Computers.Find(3);
Console.WriteLine($"Encontrado com Id 3: {encontrado.Ram}, {encontrado.Processor}");

// Update (UPDATE)
encontrado.Ram = "10GB";
encontrado.Processor = "amd";
context.Computers.Update(encontrado);
context.SaveChanges();

// Read (SELECT)
Computer atualizado = context.Computers.Find(3);
Console.WriteLine($"Atualizado com Id 3: {atualizado.Ram}, {atualizado.Processor}");

// Delete (DELETE)
context.Computers.Remove(atualizado);
context.SaveChanges();