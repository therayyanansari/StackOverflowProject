using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace StackOverflowProject.ServiceLayer
{
    public static class MapperExtensions
    {
        public static void IgnoreUnmappedProperties(TypeMap map, IMappingExpression expr)
        {
            foreach(string propname in map.GetUnmappedPropertyNames())
            {
                if(map.SourceType.GetProperty(propname) != null)
                {
                    expr.ForSourceMember(propname, opt => opt.DoNotValidate());
                }
                if(map.DestinationType.GetProperty(propname) != null)
                {
                    expr.ForMember(propname, opt => opt.Ignore());
                }

            }
        }

        public static void IgnoreUnmapped(this IProfileExpression profile)
        {
            profile.ForAllMaps(IgnoreUnmappedProperties);
        }
    }
}
