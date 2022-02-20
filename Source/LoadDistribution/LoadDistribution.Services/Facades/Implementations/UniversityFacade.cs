﻿using AutoMapper;
using LoadDistribution.Core.Domain.Models;
using LoadDistribution.Core.DTO;
using LoadDistribution.Services.Repositories;
using System;

namespace LoadDistribution.Services.Facades.Implementations
{
    public class UniversityFacade : ProjectRelatedCollectionFacade<University, UniversityDTO>, IUniversityFacade
    {
        #region Fields
        private readonly IUniversityRepository _universityRepository;
        #endregion

        #region Constructors
        public UniversityFacade(IUniversityRepository universityRepository, IMapper mapper) : base(universityRepository, mapper)
        {
            _universityRepository = universityRepository ?? throw new ArgumentNullException(nameof(universityRepository));
        }
        #endregion
    }
}
