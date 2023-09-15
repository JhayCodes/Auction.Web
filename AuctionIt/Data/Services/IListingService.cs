﻿using AuctionIt.Models;

namespace AuctionIt.Data.Services
{
    public interface IListingService
    {
        IQueryable<Listing> GetAll();

        Task Add(Listing obj);

    }
}
