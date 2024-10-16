// Add todos
public class SeedData
{
    public static void Init()
    {
        TodoContext tc = new TodoContext();

        Todo Nicolas = new Todo
        {
            Id = 1,
            Task = "Nicolas Corney",
            Completed = true,
            Deadline = DateTime.Parse("2016-09-01"),
        };
        Todo Anthony = new Todo
        {
            Id = 2,
            Task = "Anthony Bonar",
            Completed = true,
            Deadline = DateTime.Parse("2018-09-09"),
        };
        Todo Eudeez = new Todo
        {
            Id = 3,
            Task = "Eudeez",
            Completed = false,
            Deadline = DateTime.Parse("2024-10-16"),
        };

        tc.Todos.AddRange(Nicolas, Anthony, Eudeez);

        tc.SaveChanges();
    }
}