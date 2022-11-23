using Microsoft.EntityFrameworkCore;
using MonkeyAPI6.Data;
namespace MonkeyAPI6;

public static class MonkeyEndpoints
{
    public static void MapMonkeyEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Monkey", async (MonkeyAPI6Context db) =>
        {
            return await db.Monkey.ToListAsync();
        })
        .WithName("GetAllMonkeys")
        .Produces<List<Monkey>>(StatusCodes.Status200OK);

        routes.MapGet("/api/Monkey/{id}", async (int Id, MonkeyAPI6Context db) =>
        {
            return await db.Monkey.FindAsync(Id)
                is Monkey model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetMonkeyById")
        .Produces<Monkey>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        routes.MapPut("/api/Monkey/{id}", async (int Id, Monkey monkey, MonkeyAPI6Context db) =>
        {
            var foundModel = await db.Monkey.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }
            //update model properties here

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateMonkey")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/Monkey/", async (Monkey monkey, MonkeyAPI6Context db) =>
        {
            db.Monkey.Add(monkey);
            await db.SaveChangesAsync();
            return Results.Created($"/Monkeys/{monkey.Id}", monkey);
        })
        .WithName("CreateMonkey")
        .Produces<Monkey>(StatusCodes.Status201Created);

        routes.MapDelete("/api/Monkey/{id}", async (int Id, MonkeyAPI6Context db) =>
        {
            if (await db.Monkey.FindAsync(Id) is Monkey monkey)
            {
                db.Monkey.Remove(monkey);
                await db.SaveChangesAsync();
                return Results.Ok(monkey);
            }

            return Results.NotFound();
        })
        .WithName("DeleteMonkey")
        .Produces<Monkey>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);
    }
}
