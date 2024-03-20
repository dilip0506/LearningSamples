namespace WebBlog.GaurdClaues
{
    public static class Gaurd<TEntity>
    {
        public static void IsNull(TEntity entity, string argumentName)
        {
            if (entity == null)
                throw new ArgumentNullException(argumentName);
        }
        public static void IsCollectionEmpty(IEnumerable<TEntity> entities, string message)
        {
            if (!entities.Any())
                throw new ArgumentException(message);
        }

        public static void Requires(Func<bool> predicate, string message)
        {
            if (predicate()) return;
            throw new ArgumentException(message);
        }
    }
}