using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.Mapping
{
    public static class MapperHelper
    {
        public static List<Tuple<Type, Type>> ObterClassesMapeaveis()
        {
            var retorno = new List<Tuple<Type, Type>>();

            //Pega todas as ViewModels que implementam IViewModelComId<T> >>> IMapeavel<T>
            var todasClassesMapeaveis = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => x.GetInterfaces()
                    .Where(i => i.IsGenericType &&
                                i.GetGenericTypeDefinition() == typeof(IMapeavel<>))
                    .SelectMany(i => i.GetGenericArguments()).Any());

            foreach (var classeMapeavel in todasClassesMapeaveis)
            {
                //Pega cada IMapeavel com sua respectiva generalização <T>
                var interfacesMapeaveis = classeMapeavel.GetInterfaces()
                    .Where(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IMapeavel<>)).ToList();

                foreach (var interfaceMapeavel in interfacesMapeaveis)
                {
                    //Obtém cada classe informada na generalização de IMapeavel<T>
                    var classe = interfaceMapeavel.GenericTypeArguments.First();

                    retorno.Add(new Tuple<Type, Type>(classe, classeMapeavel));
                    retorno.Add(new Tuple<Type, Type>(classeMapeavel, classe));
                }
            }

            return retorno;
        }
    }
}
