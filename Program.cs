using Unidade2.Classes;

Pessoas[] people = new Pessoas[]
{
  new Dono{
    Name = "Guilherme Antonio Surdi",
    BornDate = new(year: 2001, month: 12, day: 3),
    Cpf = "999.999.999-99",
    EntryDate = new(year: 2023, month: 1, day: 1),
  },
  new Gerente{
    Name = "Guilherme Surdi",
    BornDate = new(year: 2001, month: 12, day: 3),
    Cpf = "888.888.888-88",
    NumberOfAssignedDepartments = 2,
  },
  new Trabalhador{
    Name = "Guilherme",
    BornDate = new(year: 2001, month: 12, day: 3),
    Cpf = "777.777.777-77",
    ServiceHours = 10,
  }
};

for (int i = 0; i < people.Length; i++)
{
  var person = people[i];
  Console.WriteLine($"Nome: {person.Name}");
  Console.WriteLine($"Data de nascimento: {person.BornDate.ToShortDateString()}");
  Console.WriteLine($"Cpf: {person.Cpf}");
}
