﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOfAlifTech.Domain.Configurations;

namespace TaskOfAlifTech.Service.Extensions
{
    public static class CollectionExtension
    {
        public static IQueryable<T> ToPagedList<T>(this IQueryable<T> source, PaginationParams? @params)
        {
            @params ??= new PaginationParams();

            return @params.PageIndex > 0 && @params.PageSize >= 0
                ? source.Skip((int)((@params.PageIndex - 1) * @params.PageSize)).Take((int)@params.PageSize)
                : source;
        }
    }
}
