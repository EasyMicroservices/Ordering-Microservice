﻿using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class CreateOrderRequestContract : IUniqueIdentitySchema
    {
        [ContentLanguage(nameof(OrderContract.Name))]
        public List<LanguageDataContract> Names { get; set; }

        [ContentLanguage(nameof(OrderContract.Description))]
        public List<LanguageDataContract> Descriptions { get; set; }

        public List<OrderPriceContract> Prices { get; set; }
        public long ProductId { get; set; }
        public string UniqueIdentity { get; set; }
        public long? ParentId { get; set; }

        public List<CreateOrderRequestContract> Children { get; set; }
    }
}