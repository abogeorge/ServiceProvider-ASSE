﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace DataMapper
{
    class DataMapperContext : DbContext
    {
        public DataMapperContext() : base("connection_string")
        {
            Database.SetInitializer<DataMapperContext>(new DropCreateDatabaseAlways<DataMapperContext>());
        }

        public DbSet<Customer> Customers
        {
            get;
            set;
        }

        public DbSet<SubscriptionType> SubscriptionTypes
        {
            get;
            set;
        }

        public DbSet<MinuteType> MinuteTypes
        {
            get;
            set;
        }

        public DbSet<MessageType> MessageTypes
        {
            get;
            set;
        }

        public DbSet<Currency> Currencies
        {
            get;
            set;
        }

        public DbSet<CurrencyRate> CurrencieRates
        {
            get;
            set;
        }

        public DbSet<Minute> Minutes
        {
            get;
            set;
        }

        public DbSet<Message> Messages
        {
            get;
            set;
        }

        public DbSet<Subscription> Subscriptions
        {
            get;
            set;
        }

        public DbSet<Contract> Contracts
        {
            get;
            set;
        }
    }
}
