namespace DataAccessDapper.Models
{
    public record CountryModel(string Name, string Code, string Currency)
    {
        public CountryModel() : this(null, null, null)
        {
        }
    }
}
