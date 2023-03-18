public static class QuestionDatabase
{
    public static readonly List<Question> Questions = new()
    {
        new("What is the largest planet in our solar system?", new[] { "A) Earth", "B) Jupiter", "C) Saturn", "D) Venus" }, "B"),
        new("What is the capital of France?", new[] { "A) Berlin", "B) Madrid", "C) Paris", "D) Rome" }, "C"),
        new("What is the largest mammal on Earth?", new[] { "A) Elephant", "B) Blue whale", "C) Giraffe", "D) Hippopotamus" }, "B"),
        new("What is the smallest country in the world?", new[] { "A) Monaco", "B) Nauru", "C) Vatican City", "D) San Marino" }, "C"),
        new("What is the name of the tallest mountain in the world?", new[] { "A) Denali", "B) Mount Everest", "C) Kilimanjaro", "D) Mauna Kea" }, "B")
    };
}
