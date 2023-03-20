using workingWithClasses;

Subject[] grades =
{
    new Subject("МДК 01.01", true, 5),
    new Subject("МДК 04.01", false, 2),
    new Subject("МДК 04.02", false, 2),
    new Subject("МДК 11.01", true, 5),
    new Subject("Основы алгоритмизации", true, 5),
};

foreach (Subject subject in grades)
{
    Console.WriteLine(subject.ToString());
}