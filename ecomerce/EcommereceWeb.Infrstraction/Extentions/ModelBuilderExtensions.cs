using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace EcommereceWeb.Infrstraction.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ApplayGlobalFilter<TInterface>(this ModelBuilder modelBuilder, Expression<Func<TInterface,bool>> expression)
        {
            var entities = modelBuilder.Model.GetEntityTypes().Where(x => x.ClrType.GetInterface(typeof(TInterface).Name) !=null).Select(e=>e.ClrType);
       foreach (var   entity in entities)
            {
                var newParm= Expression.Parameter(entity);
                var newBody = ReplacingExpressionVisitor.Replace(expression.Parameters.Single(), newParm, expression.Body);
                modelBuilder.Entity(entity).HasQueryFilter(Expression.Lambda( newBody, newParm));

            }
        
        }
        public static void ApplayGlobalFilter<TInterface>(this ModelBuilder modelBuilder, Expression<Func<TInterface, DateTime>> expression)
        {
            var entities = modelBuilder.Model.GetEntityTypes().OrderBy(x => x.ClrType.GetInterface(typeof(TInterface).Name)).Select(e => e.ClrType);
            foreach (var entity in entities)
            {
                var newParm = Expression.Parameter(entity);
                var newBody = ReplacingExpressionVisitor.Replace(expression.Parameters.Single(), newParm, expression.Body);
                modelBuilder.Entity(entity).HasQueryFilter(Expression.Lambda(newBody, newParm));

            }

        }
    }
}
