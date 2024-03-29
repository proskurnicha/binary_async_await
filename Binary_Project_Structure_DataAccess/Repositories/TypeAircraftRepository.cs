﻿using System;
using System.Collections.Generic;
using System.Text;
using Binary_Project_Structure_DataAccess.Repositories;
using Binary_Project_Structure_DataAccess.Models;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Linq;

namespace Binary_Project_Structure_DataAccess.Repositories
{
    public  class TypeAircraftRepository : Repository<TypeAircraft>
    {
        public async override Task<TypeAircraft> Update(TypeAircraft entity)
        {
            Expression<Func<TypeAircraft, bool>> filter = x => x.Id == entity.Id;
            TypeAircraft typeAircraft = await base.GetById(filter);
            
            if (typeAircraft == null)
                return null;

            context.Set<TypeAircraft>().FirstOrDefault(filter).NumberPlaces = entity.NumberPlaces;
            context.Set<TypeAircraft>().FirstOrDefault(filter).AircraftModel = entity.AircraftModel;
            context.Set<TypeAircraft>().FirstOrDefault(filter).CarryingCapacity = entity.CarryingCapacity;
            await context.SaveChangesAsync();
            return typeAircraft;
        }
    }
}
