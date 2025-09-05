
//using Microsoft.EntityFrameworkCore;
//using project_cls.DAL.DataAccess.Models;
//using project_cls.DAL.DataAcess_Contracts;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http.HttpResults;
//using Microsoft.AspNetCore.OpenApi;
//using project_cls.DAL;

//namespace project_cls.DAL.DataAccess.Repositories
//{
//    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
//    {
//        public CategoryRepo(AppDbContext db) : base(db)
//        {
//        }
//        public override IEnumerable<Category> GetAll()
//        {
//            return _dbSet
//                .Include(Category => Category.Products);
//        }

//    }


//    public static class CategoryEndpoints
//    {
//        public static void MapCategoryEndpoints(this IEndpointRouteBuilder routes)
//        {
//            var group = routes.MapGroup("/api/Category").WithTags(nameof(Category));

//            group.MapGet("/", async (AppDbContext db) =>
//            {
//                return await db.Categories.ToListAsync();
//            })
//            .WithName("GetAllCategories")
//            .WithOpenApi();

//            group.MapGet("/{id}", async Task<Results<Ok<Category>, NotFound>> (int categoryid, AppDbContext db) =>
//            {
//                return await db.Categories.AsNoTracking()
//                    .FirstOrDefaultAsync(model => model.CategoryId == categoryid)
//                    is Category model
//                        ? TypedResults.Ok(model)
//                        : TypedResults.NotFound();
//            })
//            .WithName("GetCategoryById")
//            .WithOpenApi();

//            group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int categoryid, Category category, AppDbContext db) =>
//            {
//                var affected = await db.Categories
//                    .Where(model => model.CategoryId == categoryid)
//                    .ExecuteUpdateAsync(setters => setters
//                      .SetProperty(m => m.CategoryId, category.CategoryId)
//                      .SetProperty(m => m.CategoryName, category.CategoryName)
//                      );
//                return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
//            })
//            .WithName("UpdateCategory")
//            .WithOpenApi();

//            group.MapPost("/", async (Category category, AppDbContext db) =>
//            {
//                db.Categories.Add(category);
//                await db.SaveChangesAsync();
//                return TypedResults.Created($"/api/Category/{category.CategoryId}", category);
//            })
//            .WithName("CreateCategory")
//            .WithOpenApi();

//            group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int categoryid, AppDbContext db) =>
//            {
//                var affected = await db.Categories
//                    .Where(model => model.CategoryId == categoryid)
//                    .ExecuteDeleteAsync();
//                return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
//            })
//            .WithName("DeleteCategory")
//            .WithOpenApi();
//        }
//    }
//}





////using Microsoft.EntityFrameworkCore;
////using project_cls.DAL.DataAccess.Models;
////using project_cls.DAL.DataAcess_Contracts;
////using System.Collections.Generic;
////using System.Linq;

////namespace project_cls.DAL.DataAccess.Repositories
////{
////    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
////    {
////        public CategoryRepo(AppDbContext db) : base(db)
////        {
////        }

////        public override IEnumerable<Category> GetAll(string includeProperties = "")
////        {
////            IQueryable<Category> query = db.Categories;

////            if (includeProperties.Contains("Products"))
////            {
////                query = query.Include(c => c.Products);
////            }

////            return query.ToList();
////        }
////    }
////}





















using project_cls.DAL.DataAccess.Models;
using project_cls.DAL.DataAcess_Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cls.DAL.DataAccess.Repositories
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext db) : base(db)
        {
        }
    }
}

