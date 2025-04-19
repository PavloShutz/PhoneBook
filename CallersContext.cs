using Microsoft.EntityFrameworkCore;

namespace Phone_Book;

public class CallersContext : DbContext
{
    public DbSet<Caller> Callers { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=callers.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "All" },
            new Category { CategoryId = 2, Name = "Family" },
            new Category { CategoryId = 3, Name = "Work" },
            new Category { CategoryId = 4, Name = "Friends" },
            new Category { CategoryId = 5, Name = "Other" }
        );

        modelBuilder.Entity<Caller>().HasData(
            new Caller { CallerId = 1, Name = "Pasha", Number = "(+38)-096-123-0001", Email = "pasha@gmail.com", Address = "123 Main St", CategoryId = 2 },
            new Caller { CallerId = 2, Name = "Olga", Number = "(+38)-068-987-0002", Email = "olga@ukr.net", Address = "456 Elm St", CategoryId = 3 },
            new Caller { CallerId = 3, Name = "Ivan", Number = "(+38)-096-654-0003", Email = "ivan@yahoo.com", Address = "789 Oak St", CategoryId = 4 },
            new Caller { CallerId = 4, Name = "Sofia", Number = "(+38)-068-321-0004", Email = "sofia@example.com", Address = "101 Pine St", CategoryId = 5 },
            new Caller { CallerId = 5, Name = "Dmytro", Number = "(+38)-096-555-0005", Email = "dmytro@gmail.com", Address = "202 Maple St", CategoryId = 2 },
            new Caller { CallerId = 6, Name = "Kateryna", Number = "(+38)-068-789-0006", Email = "kateryna@ukr.net", Address = "303 Birch St", CategoryId = 3 },
            new Caller { CallerId = 7, Name = "Andriy", Number = "(+38)-096-345-0007", Email = "andriy@yahoo.com", Address = "404 Cedar St", CategoryId = 4 },
            new Caller { CallerId = 8, Name = "Natalia", Number = "(+38)-068-234-0008", Email = "natalia@example.com", Address = "505 Walnut St", CategoryId = 5 },
            new Caller { CallerId = 9, Name = "Oleh", Number = "(+38)-096-876-0009", Email = "oleh@gmail.com", Address = "606 Chestnut St", CategoryId = 2 },
            new Caller { CallerId = 10, Name = "Mariya", Number = "(+38)-068-543-0010", Email = "mariya@ukr.net", Address = "707 Spruce St", CategoryId = 3 },
            new Caller { CallerId = 11, Name = "Serhiy", Number = "(+38)-096-432-0011", Email = "serhiy@yahoo.com", Address = "808 Fir St", CategoryId = 4 },
            new Caller { CallerId = 12, Name = "Yulia", Number = "(+38)-068-765-0012", Email = "yulia@example.com", Address = "909 Willow St", CategoryId = 5 },
            new Caller { CallerId = 13, Name = "Volodymyr", Number = "(+38)-096-678-0013", Email = "volodymyr@gmail.com", Address = "1010 Poplar St", CategoryId = 2 },
            new Caller { CallerId = 14, Name = "Anastasia", Number = "(+38)-068-890-0014", Email = "anastasia@ukr.net", Address = "1111 Aspen St", CategoryId = 3 },
            new Caller { CallerId = 15, Name = "Bohdan", Number = "(+38)-096-210-0015", Email = "bohdan@yahoo.com", Address = "1212 Redwood St", CategoryId = 4 },
            new Caller { CallerId = 16, Name = "Viktoria", Number = "(+38)-068-432-0016", Email = "viktoria@example.com", Address = "1313 Sequoia St", CategoryId = 5 },
            new Caller { CallerId = 17, Name = "Mykola", Number = "(+38)-096-543-0017", Email = "mykola@gmail.com", Address = "1414 Cypress St", CategoryId = 2 },
            new Caller { CallerId = 18, Name = "Iryna", Number = "(+38)-068-654-0018", Email = "iryna@ukr.net", Address = "1515 Magnolia St", CategoryId = 3 },
            new Caller { CallerId = 19, Name = "Taras", Number = "(+38)-096-765-0019", Email = "taras@yahoo.com", Address = "1616 Dogwood St", CategoryId = 4 },
            new Caller { CallerId = 20, Name = "Liliya", Number = "(+38)-068-876-0020", Email = "liliya@example.com", Address = "1717 Hickory St", CategoryId = 5 },
            new Caller { CallerId = 21, Name = "Petro", Number = "(+38)-096-987-0021", Email = "petro@gmail.com", Address = "1818 Sycamore St", CategoryId = 2 },
            new Caller { CallerId = 22, Name = "Oksana", Number = "(+38)-068-109-0022", Email = "oksana@ukr.net", Address = "1919 Beech St", CategoryId = 3 },
            new Caller { CallerId = 23, Name = "Hanna", Number = "(+38)-096-218-0023", Email = "hanna@yahoo.com", Address = "2020 Alder St", CategoryId = 4 },
            new Caller { CallerId = 24, Name = "Ruslan", Number = "(+38)-068-327-0024", Email = "ruslan@example.com", Address = "2121 Maple St", CategoryId = 5 },
            new Caller { CallerId = 25, Name = "Ludmila", Number = "(+38)-096-436-0025", Email = "ludmila@gmail.com", Address = "2222 Elm St", CategoryId = 2 },
            new Caller { CallerId = 26, Name = "Roman", Number = "(+38)-068-545-0026", Email = "roman@ukr.net", Address = "2323 Oak St", CategoryId = 3 },
            new Caller { CallerId = 27, Name = "Vasyl", Number = "(+38)-096-654-0027", Email = "vasyl@yahoo.com", Address = "2424 Pine St", CategoryId = 4 },
            new Caller { CallerId = 28, Name = "Oleksii", Number = "(+38)-068-763-0028", Email = "oleksii@example.com", Address = "2525 Cedar St", CategoryId = 5 },
            new Caller { CallerId = 29, Name = "Alina", Number = "(+38)-096-872-0029", Email = "alina@gmail.com", Address = "2626 Walnut St", CategoryId = 2 },
            new Caller { CallerId = 30, Name = "Denys", Number = "(+38)-068-981-0030", Email = "denys@ukr.net", Address = "2727 Chestnut St", CategoryId = 3 }
        );

    }
}
