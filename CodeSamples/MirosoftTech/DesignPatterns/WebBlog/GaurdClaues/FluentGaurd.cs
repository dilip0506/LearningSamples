namespace WebBlog.GaurdClaues
{
    //Singleton pattern
    public class FluentGaurd<TEntity>
    {
        private FluentGaurd() { }

        public static FluentGaurd<TEntity> Throw()
        {
            return new FluentGaurd<TEntity>();
        }

        public FluentGaurd<TEntity> IsNull(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            return this;
        }

        public FluentGaurd<TEntity> IsCollectionEmpty(IEnumerable<TEntity> entities)
        {
            if (!entities.Any())
                throw new ArgumentException(nameof(entities));
            return this;
        }

    }
}
