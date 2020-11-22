using AutoMapper;

namespace WebAPI.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            var classesMapeaveis = MapperHelper.ObterClassesMapeaveis();

            foreach (var classeMapeal in classesMapeaveis)
            {
                CreateMap(classeMapeal.Item1, classeMapeal.Item2);
            }
        }
    }
}