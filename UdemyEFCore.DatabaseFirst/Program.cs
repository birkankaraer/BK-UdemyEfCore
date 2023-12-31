﻿using Microsoft.EntityFrameworkCore;
using UdemyEFCore.DatabaseFirst.DataAccessLayer;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    var produtcs = await _context.Products.ToListAsync();

    produtcs.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}: {p.Name} - {p.Price} - {p.Stock}");
        //{p.Stock.hasvalue} kodu ile değerin null olup olmadığını kontrol edebiliriz
    });
}
