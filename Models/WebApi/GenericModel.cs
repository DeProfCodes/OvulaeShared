namespace OvulaeShared.Models.WebApi
{
    /// <summary>
    /// Generic Model class that is used to return api with fewer model fields to limit creating multiple model classes
    /// </summary>
    /// <typeparam name="T">Tye parse in runtime</typeparam>
    public class GenericModel<T>
    {
        public T Field { get; set; }

        public T Field2 { get; set; }
    }
}
