using AbstractFactory.Products.Command;
using AbstractFactory.Products.Connection;
using System.Data;

namespace AbstractFactory.Factories;

// Abstract Factory
public abstract class DatabaseFactory
{
    public abstract Command CreateCommand();

    public abstract Connection CreateConnection();

}