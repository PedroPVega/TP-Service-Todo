// Add todos
using System.Net.Sockets;

public class SeedData
{
    public enum Completition
    {
        True,
        False
    }
    public static void Init()
    {
        TodoContext tc = new TodoContext();
        if( tc.Todos.Count() == 0)
        {
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

    public static void PrintTodos()
    {
        TodoContext tc = new TodoContext();
        Console.WriteLine("----- Liste de tous les todos -----");
        foreach (Todo todo in tc.Todos)
            Console.WriteLine("Todo {0}, task: {1}, completed: {2}",todo.Id, todo.Task, todo.Completed.ToString());

        Console.WriteLine("----- Liste des todos non terminés -----");
        foreach (Todo todo in tc.Todos)
        {
            if (!todo.Completed)
            {
                Console.WriteLine("Todo {0}, task: {1}, completed: {2}",todo.Id, todo.Task, todo.Completed.ToString());
            }
        }
    }

    public static void EraseTodos()
    {
        TodoContext tc = new TodoContext();
        foreach (Todo todo in tc.Todos)
            tc.Remove(todo);
        
        Console.WriteLine("La base de données a été purgé de données");
        tc.SaveChanges();
    }
}