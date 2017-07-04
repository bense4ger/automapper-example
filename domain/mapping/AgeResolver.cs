using System;
using automapper.example.data.entities;
using automapper.example.domain.models;
using AutoMapper;

namespace automapper.example.domain.mapping
{
    public class AgeResolver : IValueResolver<Bar, BarModel, int>
    {
        public int Resolve(Bar source, BarModel destination, int destMember, ResolutionContext context)
        {
            return DateTime.Now.Year - source.DateOfBirth.Year;
        }
    }
}
