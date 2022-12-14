//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Data Transfer Object template.
// Code is generated on: 20/09/2022 10:58:30 pm
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace FrontDeskApp.Data.DTO
{

    public static partial class AreaBoxConverter
    {

        public static AreaBoxDto ToDto(this FrontDeskApp.Entities.AreaBox source)
        {
            return source.ToDtoWithRelated(0);
        }

        public static AreaBoxDto ToDtoWithRelated(this FrontDeskApp.Entities.AreaBox source, int level)
        {
            if (source == null)
              return null;

            var target = new AreaBoxDto();

            // Properties
            target.AreaBoxId = source.AreaBoxId;
            target.Name = source.Name;
            target.AreaType = source.AreaType;
            target.Status = source.Status;

            // Navigation Properties
            if (level > 0) {
              target.Transactions = source.Transactions.ToDtosWithRelated(level - 1);
            }

            // User-defined partial method
            OnDtoCreating(source, target);

            return target;
        }

        public static FrontDeskApp.Entities.AreaBox ToEntity(this AreaBoxDto source)
        {
            if (source == null)
              return null;

            var target = new FrontDeskApp.Entities.AreaBox();

            // Properties
            target.AreaBoxId = source.AreaBoxId;
            target.Name = source.Name;
            target.AreaType = source.AreaType;
            target.Status = source.Status;

            // User-defined partial method
            OnEntityCreating(source, target);

            return target;
        }

        public static List<AreaBoxDto> ToDtos(this IEnumerable<FrontDeskApp.Entities.AreaBox> source)
        {
            if (source == null)
              return null;

            var target = source
              .Select(src => src.ToDto())
              .ToList();

            return target;
        }

        public static List<AreaBoxDto> ToDtosWithRelated(this IEnumerable<FrontDeskApp.Entities.AreaBox> source, int level)
        {
            if (source == null)
              return null;

            var target = source
              .Select(src => src.ToDtoWithRelated(level))
              .ToList();

            return target;
        }

        public static List<FrontDeskApp.Entities.AreaBox> ToEntities(this IEnumerable<AreaBoxDto> source)
        {
            if (source == null)
              return null;

            var target = source
              .Select(src => src.ToEntity())
              .ToList();

            return target;
        }

        static partial void OnDtoCreating(FrontDeskApp.Entities.AreaBox source, AreaBoxDto target);

        static partial void OnEntityCreating(AreaBoxDto source, FrontDeskApp.Entities.AreaBox target);

    }

}
