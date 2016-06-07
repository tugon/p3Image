using AutoMapper;

namespace P3Image.Web.EntityMapping
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<EntitiesProfile>();
            });
        }
    }
}